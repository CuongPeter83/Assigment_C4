using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assignment.Models.Data
{
    public class Shopping_Dbcontext : DbContext
    {
        public Shopping_Dbcontext() { }
        public Shopping_Dbcontext(DbContextOptions options) : base(options)
        {

        }
        // DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Capacity> Capacities { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B6TM0SA\MSSQLSERVER2;Initial Catalog=Assignment;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
