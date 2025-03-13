using Microsoft.EntityFrameworkCore;
using CompanyService.Entities; // Ensure that the Person class is defined in this namespace or update to the correct namespace

namespace CompanyService.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=Saminathan;Database=Person;TrustServerCertificate=True;");
            }
        }

        public DbSet<Company> Companies { get; set; }
    }
}