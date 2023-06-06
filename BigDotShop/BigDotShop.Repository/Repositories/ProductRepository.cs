using BigDotShop.Core.Entities;
using BigDotShop.Repository.Abstractions;
using BigDotShop.Repository.EFCore;

namespace BigDotShop.Repository.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly List<Product> values;

        public ProductRepository(BigShopDbContext context) : base(values: context.products)
        {
            this.values = context.products;
           
        }


        public IEnumerable<Product> GetProducOfSubCategory(SubCategory subCategory)
        {
           var result = values.Where(kk=> kk.SubCategory == subCategory);
            return result;
        }

        public IEnumerable<Product> GetProductOfBrand(Brand brand)
        {
           return values.Where(kk=> kk.Brand == brand);
        }

        public IEnumerable<Product> GetProductOfCategory(Category category)
        {
            return values.Where(aa=>aa.Category == category);
        }
    }
}
