

using Microsoft.EntityFrameworkCore;

namespace TesteDesenvolvimentoAPI.Models
{
    public class DbTesteContext : DbContext
    {
        public DbTesteContext(DbContextOptions<DbTesteContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
  
        }
        public DbSet<Tool> Tools { get; set; }
    }
}
