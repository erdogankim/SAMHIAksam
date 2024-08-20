using Microsoft.EntityFrameworkCore;

namespace Gun24_Blazor_Ornek.Entities
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Northwind; User Id=sa; Password=1; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
