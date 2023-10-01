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
        private readonly CategoryRepository _categoryRepository;

        public CategoryManager(StokTakipDbContext context)
        {
            _categoryRepository = new CategoryRepository(context);
        }

        public bool Add(Category category)
        {
            int result = _categoryRepository.Add(category);

            if (result > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Category category)
        {
            int result = _categoryRepository.Delete(category);

            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
