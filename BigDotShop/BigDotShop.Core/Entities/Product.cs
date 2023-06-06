

using BigDotShop.Core.Enums;

namespace BigDotShop.Core.Entities
{
    public class Product : BaseEntity
    {

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public Colors? Color { get; set; }

        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public SubCategory? SubCategory { get; set; }

    }
}
