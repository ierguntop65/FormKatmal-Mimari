using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyResolvers.Ninject
{
    using global::Ninject;
    using global::Ninject.Modules;

    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BussinessModul());
            return kernel.Get<T>();
        }
    }

}
