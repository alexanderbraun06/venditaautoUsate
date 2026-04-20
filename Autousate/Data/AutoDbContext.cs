using Autousate.Data;
using Microsoft.EntityFrameworkCore;

public class AutoDbContext : DbContext
{
    public DbSet<Cliente> Clienti { get; set; }
    public DbSet<Auto> Auto { get; set; }
    public DbSet<Concessionaria> Concessionarie { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Cliente → Auto (1-N)
        modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Auto)
            .WithOne(a => a.Cliente)
            .HasForeignKey(a => a.IdCliente);

        // Cliente → Concessionaria (N-1)
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Concessionaria)
            .WithMany(ca => ca.Clienti)
            .HasForeignKey(c => c.IdConcessionaria);

        // Auto → Concessionaria (N-1)
        modelBuilder.Entity<Auto>()
            .HasOne(a => a.Concessionaria)
            .WithMany(ca => ca.Auto)
            .HasForeignKey(a => a.Concessionaria);
    }
}