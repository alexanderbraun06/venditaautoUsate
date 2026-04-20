using Autousate.Data;

namespace Autousate.Dto
{
    public class ClienteDto
    {
        public int IdAuto { get; set; }
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DatadiNascita { get; set; }
        public string LuogodiNascita { get; set; }
        public string NumeroCellulare { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
