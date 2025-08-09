using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopAdmin.Models
{
    public class BPSDdContext : DbContext
    {
        public BPSDdContext(DbContextOptions<BPSDdContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configurations
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BPSDdContext).Assembly);
        }
    }
}
