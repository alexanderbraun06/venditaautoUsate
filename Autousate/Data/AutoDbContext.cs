using Microsoft.EntityFrameworkCore;

namespace Autousate.Data
{
    public class AutoDbContext : DbContext
    {
        public AutoDbContext(DbContextOptions<AutoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Auto> Auto { get; set; }
        public DbSet<Concessionaria> Concessionarie { get; set; }
    }
}