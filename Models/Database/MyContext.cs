using Microsoft.EntityFrameworkCore;

namespace products_categories.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        // MAKE SURE you are adding a DbSet for every single model
        // you wish to translate to the database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Produgory> Produgories { get; set; }
    }
}