using StokTakip.Business.Abstract;
using StokTakip.DataAccess.Abstract;
using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public bool Add(Product entity)
        {
            int result = _productDAL.Add(entity);

            if (result > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Product entity)
        {

            int result = _productDAL.Delete(entity);

            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetAll();
        }

        public bool Update(Product entity)
        {

            int result = _productDAL.Update(entity);

            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
