using BigDotShop.Core.Entities;

namespace BigDotShop.Repository.Abstractions
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductOfBrand(Brand brand);
        IEnumerable<Product> GetProductOfCategory(Category category);
        IEnumerable<Product> GetProducOfSubCategory(SubCategory subCategory);
    }
}
