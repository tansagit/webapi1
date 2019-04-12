
using Microsoft.EntityFrameworkCore;


namespace webapi1.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}