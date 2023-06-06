namespace BigDotShop.Core.Entities
{
    public class SubCategory :BaseEntity
    {
        public SubCategory(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public SubCategory? Sub { get; set; }
        public Category? Category { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Brand>? Brands { get; set; }

    }
}
