using BigDotShop.Repository.Abstractions;
using BigDotShop.Repository.Repositories;
using Ninject.Modules;

namespace BigDotShop.Service.Module
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IProductRepository>().To<ProductRepository>().InSingletonScope();
        }
    }
}
