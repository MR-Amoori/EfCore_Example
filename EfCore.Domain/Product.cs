namespace EfCore.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public bool IsRemoved { get; set; }

        public int CategortId { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, double unitPrice, int categortId)
        {
            Name = name;
            UnitPrice = unitPrice;
            IsRemoved = false;
            CategortId = categortId;
        }

        public void Edit(string name, double unitPrice, int categortId)
        {
            Name = name;
            UnitPrice = unitPrice;
            CategortId = categortId;
        }

        public void Delete()
        {
            this.IsRemoved = true;
        }

        public void Restore()
        {
            this.IsRemoved = false;
        }
    }
}