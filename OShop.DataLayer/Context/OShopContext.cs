

using Microsoft.EntityFrameworkCore;
using OShop.DataLayer.Entities;

namespace OShop.DataLayer
{
    public class OShopContext : DbContext
    {
        public OShopContext
            (DbContextOptions<OShopContext> options)
        : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questionss { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cart> Carts { get; set; }



    }
}
