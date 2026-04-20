namespace Autousate.Data
{
    public class Cliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DatadiNascita { get; set; }
        public string LuogodiNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string NumeroCartaIdentita { get; set; }
        public string IndirizzodiResidenza { get; set; }
        public string NumeroCellulare { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Auto Auto;
        public Concessionaria Concessionaria { get; set; }

    }
}
