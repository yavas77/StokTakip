using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.Concrete.Contexts;
using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Concrete.EfCore
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryDAL
    {
        public CategoryRepository(StokTakipDbContext context) : base(context)
        {
        }
    
    }
}
