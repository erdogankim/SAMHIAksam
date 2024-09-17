using Microsoft.EntityFrameworkCore;

namespace Gun30_MVCFeaturesAndPartials.Data
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
