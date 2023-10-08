using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Abstract
{
    public interface IProductDAL
    {
        int Add(Product product);
        int Update(Product product);
        int Delete(Product product);
        List<Product> GetAll();
    }
}
