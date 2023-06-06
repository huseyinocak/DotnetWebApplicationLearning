using BigDotShop.Core.Entities;
using BigDotShop.Repository.Abstractions;

namespace BigDotShop.Repository.Repositories
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private readonly List<SubCategory> values;

        public SubCategoryRepository(List<SubCategory> values) : base(values)
        {
            this.values = values;
        }

        public IEnumerable<SubCategory> GetSubCategoryOfBrand(Brand brand)
        {
            return  values.Where(aa=>  aa.Brands != null &&  aa.Brands.Contains(brand));
        }

        public IEnumerable<SubCategory> GetSubCategoryOfCategory(Category category)
        {
            return values.Where(aa => aa.Category != null && aa.Category == category);
        }
    }
}
