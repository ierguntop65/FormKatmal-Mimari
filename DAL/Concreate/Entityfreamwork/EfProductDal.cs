using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concreate.Entityfreamwork
{
    using System.Linq.Expressions;
    using DAL.Abstract;

    using Entities.Concreate;

    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
         
    }
}
