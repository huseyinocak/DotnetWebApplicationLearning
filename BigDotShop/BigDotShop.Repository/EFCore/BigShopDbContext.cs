using BigDotShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDotShop.Repository.EFCore
{
    public class BigShopDbContext
    {
        public List<Product> products;
        public BigShopDbContext(List<Product> products)
        {
            this.products = new List<Product>();
        }


    }
}
