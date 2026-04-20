namespace Autousate.Data
{
    public class Auto
    {
        public int Id { get; set; }
        public int IdAuto { get; set; }
        public string Produttore {  get; set; }
        public string Modello { get; set; }
        public DateOnly DataPrimaImmatricolazione { get; set; }
        public double NumeroKm { get; set; }
        public double Prezzo { get; set; }
        public Cliente Cliente { get; set; }
        public Concessionaria Concessionaria { get; set; }
    }
}
