using HomeyCraftProductAPI.Context;
using HomeyCraftProductAPI.Models;

namespace HomeyCraftProductAPI.Services
{
    public class StoreService
    {
        private readonly ProductContext _db = new ProductContext();
        public void GetStores()
        {
            _db.Stores.ToList();
        }
        public bool AddStore(Store s)
        {
            _db.Stores.Add(s);
            _db.SaveChanges();
            return true;
        }
    }
}
