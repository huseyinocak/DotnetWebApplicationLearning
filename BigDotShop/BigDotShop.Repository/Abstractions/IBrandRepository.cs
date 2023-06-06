using BigDotShop.Core.Entities;

namespace BigDotShop.Repository.Abstractions
{
    public interface IBrandRepository : IRepository<Brand>
    {
        IEnumerable<Brand> GetBrandOfCategory(Category category);
        IEnumerable<Brand> GetBrandOfSubCategory(SubCategory subCategory);
    }
}
