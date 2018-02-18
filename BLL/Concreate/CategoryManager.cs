using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concreate
{
    using BLL.Abstract;

    using DAL.Abstract;

    using Entities.Concreate;

    public class CategoryManager:ICategoryManager
    {
        private ICategortDal _categoryDal;

        public CategoryManager(ICategortDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public IList<Category> GetAll()
        {
            return this._categoryDal.GetAll();
        }
    }
}
