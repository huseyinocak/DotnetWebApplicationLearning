namespace BigDotShop.Core.Entities
{
    public class Category : BaseEntity
    {
        public Category(string name, ICollection<SubCategory> subCategories)
        {
            Name = name;
            SubCategories = subCategories;
        }

        
        
        public string Name { get; set; }


        public ICollection<Brand>? Brands { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
