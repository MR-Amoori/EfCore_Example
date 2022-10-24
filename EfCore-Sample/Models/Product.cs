namespace EfCore_Sample.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
