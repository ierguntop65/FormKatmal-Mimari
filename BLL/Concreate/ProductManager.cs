using DAL.Concreate;
using DAL.Concreate.Entityfreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities.Concreate;
using BLL.Abstract;

namespace BLL.Concreate
{
    using System.Data.Entity.Infrastructure;

    using BLL.Utilities;
    using BLL.ValidationRules.Fluentvalidation;

    using FluentValidation;

    public class ProductManager:IProductManager
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int CategoryId)
        {
            return this._productDal.GetAll(p => p.CategoryID == CategoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return this._productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
           ValidationTools.Validata(new ProoductValidator(), product);
            this._productDal.Add(product);
        }

        public void Update(Product product)
        {
            ValidationTools.Validata(new ProoductValidator(), product);
            this._productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                this._productDal.Delete(product);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Güncellme gerçekleşmdedi");
                
            }
        }
    }
}
