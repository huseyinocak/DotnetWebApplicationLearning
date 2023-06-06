using BigDotShop.Core.Entities;
using BigDotShop.Core.ServiceAbstract;
using BigDotShop.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDotShop.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        
        public ProductService(IRepository<Product> repository) : base(repository)
        {
            
            //this.values.AddRange(
            //    new List<Product>()
            //    {
            //        new Product( name:"Acer Nitro",description:"intel i7-12700H"){ Id=1,  Color=Colors.Navyblue, Price=20000, new Brand(name: "Acer") { Id=1} },
            //        new Product( name:"Dell Gaming",description:"intel i7-12700H"){ Id=2,  Color=Colors.Red, Price=29000},
            //        new Product( name:"Hp Victus",description:"intel i7-12700H"){ Id=3,  Color=Colors.Gray, Price=27000},
            //        new Product( name:"Asus Tuf",description:"intel i7-12650H"){ Id=4,  Color=Colors.Black, Price=32000},
            //        new Product( name:"Lenova Idepad",description:"intel i7-11390"){ Id=5,  Color=Colors.Blue, Price=23000},
            //        new Product( name:"Casper Excalibur",description:"intel i7-11600H"){ Id=6,  Color=Colors.Silver, Price=26000},
            //    });
        }
    }
}
