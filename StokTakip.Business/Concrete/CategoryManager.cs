using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.Concrete.Contexts;
using StokTakip.DataAccess.Concrete.EfCore;
using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Concrete
{
    public class CategoryManager
    {
        private readonly ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public bool Add(Category category)
        {
            int result = _categoryDAL.Add(category);

            if (result > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Category category)
        {
            int result = _categoryDAL.Delete(category);

            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
