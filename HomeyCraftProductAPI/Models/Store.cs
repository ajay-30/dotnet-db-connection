namespace HomeyCraftProductAPI.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
