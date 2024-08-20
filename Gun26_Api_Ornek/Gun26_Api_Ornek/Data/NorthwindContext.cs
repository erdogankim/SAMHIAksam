using Microsoft.EntityFrameworkCore;

namespace Gun26_Api_Ornek.Data
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Northwind; User Id=sa; Password=1; TrustServerCertificate=true");
        }
    }
}
