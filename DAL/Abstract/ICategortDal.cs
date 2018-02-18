using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    using Entities.Concreate;
    public interface ICategortDal:IEntityRepository<Category>
    {
    }
}
