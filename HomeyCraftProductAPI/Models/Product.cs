namespace HomeyCraftProductAPI.Models
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Price {  get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public  int StoreId {  get; set; }
    }
}
