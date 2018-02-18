using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using DAL.Abstract;
namespace DAL.Concreate.NHibernate
{
    using System.Linq.Expressions;
    using Entities.Concreate;

    public class NhProductDal:IProductDal
    {
          public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
                                         {
                                             new Product
                                                 {
                                                     ProductID = 3,
                                                     CategoryID = 1,
                                                     ProductName = "Elma",
                                                     QuantityPerUnit = "gdsgd",
                                                     UnitPrice = 55,
                                                     UnitsInStock = 45
                                                 }
                                         };
            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
