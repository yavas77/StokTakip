using StokTakip.Business.Concrete.DTOs.Categories;
using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Abstract
{
    public interface ICategoryService
    {
        bool Add(AddCategoryDTO addCategoryDTO);
    }
}
