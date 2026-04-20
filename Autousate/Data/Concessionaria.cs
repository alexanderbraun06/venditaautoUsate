namespace Autousate.Data
{
    public class Concessionaria
    {
        public int Id { get; set; }
        public int IdConcessionaria { get; set; }
        public string Nome { get; set; }
        public List<Auto> AutoPresenti = [];
        public List<Cliente> Clienti = [];
        
    }
}
