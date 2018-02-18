using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concreate;

namespace BLL.Abstract
{

    public interface IProductManager
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int CategoryId);
        List<Product> GetProductsByProductName(string productName);

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
