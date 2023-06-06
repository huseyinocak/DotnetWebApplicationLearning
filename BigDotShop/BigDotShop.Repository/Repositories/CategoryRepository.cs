using BigDotShop.Core.Entities;
using BigDotShop.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDotShop.Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly List<Category> values;

        public CategoryRepository(List<Category> values) : base(values)
        {
            this.values = values;
        }

        public IEnumerable<Category> GetCategoriesOfBrand(Brand brand)
        {
            return values.Where(aa=> aa.Brands != null  && aa.Brands.Contains(brand));
        }
    }
}
