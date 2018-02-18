using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyResolvers.Ninject
{
    using BLL.Abstract;
    using BLL.Concreate;

    using DAL.Abstract;
    using DAL.Concreate.Entityfreamwork;

    using global::Ninject.Modules;
    class BussinessModul:NinjectModule
    {
        public override void Load()
        {
            this.Bind<IProductManager>().To<ProductManager>();
            this.Bind<IProductDal>().To<EfProductDal>();

            this.Bind<ICategoryManager>().To<CategoryManager>();
            this.Bind<ICategortDal>().To<EfCategoryDal>();
        }
    }
}
