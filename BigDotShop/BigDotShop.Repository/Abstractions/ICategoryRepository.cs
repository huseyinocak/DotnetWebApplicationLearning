using BigDotShop.Core.Entities;

namespace BigDotShop.Repository.Abstractions
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetCategoriesOfBrand(Brand brand);
    }
}
