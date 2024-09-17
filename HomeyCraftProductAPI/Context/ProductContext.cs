using HomeyCraftProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeyCraftProductAPI.Context
{
    public class ProductContext: DbContext
    {
        public DbSet<Product> Products {  get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;initial catalog=homeyCraftProducts;user id=sa;password=Pass@123;trustServerCertificate=true");
        }
    }
}
