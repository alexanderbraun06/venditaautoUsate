using Autousate.Data;
using Autousate.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Autousate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoController : ControllerBase
    {
        private readonly AutoDbContext _ctx;
        private readonly ILogger<AutoController> _logger;
        private readonly Mapper _mapper;

        public AutoController(
            AutoDbContext ctx,
            ILogger<AutoController> logger,
            Mapper mapper)
        {
            _ctx = ctx;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/auto
        [HttpGet]
        public IActionResult GetAll()
        {
            var auto = _ctx.Auto
                .Include(a => a.Cliente)
                .Include(a => a.Concessionaria)
                .ToList();

            var result = auto.ConvertAll(_mapper.MapEntityToDto);
            return Ok(result);
        }

        // GET: api/auto/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var auto = _ctx.Auto
                .Include(a => a.Cliente)
                .Include(a => a.Concessionaria)
                .SingleOrDefault(a => a.Id == id);

            if (auto == null)
                return NotFound($"Auto con Id {id} non trovata");

            return Ok(_mapper.MapEntityToDto(auto));
        }

        // POST: api/auto
        [HttpPost]
        public IActionResult Create([FromBody] AutoDto dto)
        {
            var entity = _mapper.MapDtoToEntity(dto);
            entity.Id = 0; // forza INSERT

            _ctx.Auto.Add(entity);
            try
            {
                _ctx.SaveChanges();
            }
            catch
            {
                // ignorato
            }
            if (_ctx.SaveChanges() > 0)
                return CreatedAtAction(nameof(Get), new { id = entity.Id }, null);

            return BadRequest("Errore nella creazione dell'auto");
        }
    }
}
