using HomeyCraftProductAPI.Context;
using HomeyCraftProductAPI.Models;

namespace HomeyCraftProductAPI.Services
{
    public class ProductService
    {
        private readonly ProductContext _db=new ProductContext();
        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }
        public bool AddProduct(Product p)
        {
            _db.Products.Add(p);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteProduct(int id)
        {
            Product p = _db.Products.Find(id);
            if (p!=null) 
            _db.Products.Remove(p);
            _db.SaveChanges();
            return true;
        }
    }
}
