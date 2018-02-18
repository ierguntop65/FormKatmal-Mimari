using DAL.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concreate.Entityfreamwork
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, NorthwindContext>,ICategortDal
    {

    }
}
