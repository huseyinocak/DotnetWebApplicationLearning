using BigDotShop.Core.Entities;

namespace BigDotShop.Repository.Abstractions
{
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {
        IEnumerable<SubCategory> GetSubCategoryOfCategory(Category category);
        IEnumerable<SubCategory> GetSubCategoryOfBrand(Brand brand);
    }
}
