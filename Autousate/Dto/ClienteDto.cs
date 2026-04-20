using Autousate.Data;

namespace Autousate.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Cognome { get; set; }
       

        public int IdConcessionaria { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

    }
}
