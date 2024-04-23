using Microsoft.EntityFrameworkCore;
using Migrations.Entities;

namespace Migrations.DAL
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Book>Books { get; set; }
        //public DbSet<Library>Libraries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-PJER2FH7OJN;Database=DBSample;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;");
        }
    }
}
