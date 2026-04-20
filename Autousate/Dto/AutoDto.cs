using Autousate.Data;

namespace Autousate.Dto
{
    public class AutoDto
    {
        public int IdAuto { get; set; }
        public int IdCliente { get; set; }
        public string Produttore { get; set; }
        public string Modello { get; set; }
        public string Targa { get; set; }
        public DateOnly DataPrimaImmatricolazione { get; set; }
        public double NumeroKm { get; set; }
        public double Prezzo { get; set; }
        public List<AutoDto> Auto = [];
        public List<Cliente> Clienti = [];
    }
}
