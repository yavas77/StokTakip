using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Abstract
{
    public interface ICategoryDAL
    {
        int Add(Category category);
        int Update(Category category);
        int Delete(Category category);
        List<Category> GetAll();


    }
}
