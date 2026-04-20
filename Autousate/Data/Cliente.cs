using Autousate.Data;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }

    public List<Auto> Auto { get; set; } = new();

    public int IdConcessionaria { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Concessionaria Concessionaria { get; set; }
}
