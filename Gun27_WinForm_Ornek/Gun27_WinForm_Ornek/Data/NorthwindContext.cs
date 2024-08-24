using Microsoft.EntityFrameworkCore;

namespace Gun27_WinForm_Ornek.Data
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Northwind; User Id=sa; Password=1; TrustServerCertificate=true");
        }
    }
}