namespace BigDotShop.Core.Entities
{
    public class Brand : BaseEntity
    {
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public ICollection<Category>? Categories { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<SubCategory>? SubCategories { get; set; }
    }
}
