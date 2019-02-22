using Aarim.Models;
using Microsoft.EntityFrameworkCore;

namespace Aarim.Data
{
    public class DomainDbContext : DbContext
    {
        public DbSet<Transacation> Transaction { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }

        public DomainDbContext(DbContextOptions<DomainDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditCard>().HasKey(b => new { b.Number });
        }
    }
}
