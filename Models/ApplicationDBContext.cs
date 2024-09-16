using Microsoft.EntityFrameworkCore;

namespace coreEFCodeFirstApproach.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BERKAYKARA\\SQLEXPRESS;Database=CodeFirstDB;Integrated Security = true; TrustServerCertificate=True;");
        }
    }
}
