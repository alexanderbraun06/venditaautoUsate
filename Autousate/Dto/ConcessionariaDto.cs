using Autousate.Data;

namespace Autousate.Dto
{
    public class ConcessionariaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Auto> Auto { get; set; } = new();

        public int IdConcessionaria { get; set; }
        public Concessionaria Concessionaria { get; set; }


    }
}
