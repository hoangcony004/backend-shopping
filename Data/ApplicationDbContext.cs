using Microsoft.EntityFrameworkCore;
using shopping_api.Model.category;
using shopping_api.Model.order;
using shopping_api.Model.order_detal;
using shopping_api.Model.product;
using shopping_api.Model.user;

namespace shopping_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys {  get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_detall> Order_detall { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Category_Id)
                .OnDelete(DeleteBehavior.Cascade); // Xóa Category sẽ xóa Product liên quan

            base.OnModelCreating(modelBuilder);
        }

    }


}
