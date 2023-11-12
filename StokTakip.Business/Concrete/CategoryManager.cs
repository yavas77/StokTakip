using AutoMapper;
using StokTakip.Business.Abstract;
using StokTakip.Business.Concrete.DTOs.Categories;
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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryDAL categoryDAL, IMapper mapper)
        {
            _categoryDAL = categoryDAL;
            _mapper = mapper;
        }

        public bool Add(AddCategoryDTO addCategoryDTO)
        {
            //Category category = new Category
            //{
            //    Name = addCategoryDTO.Name
            //};

            Category category = _mapper.Map<Category>(addCategoryDTO);


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

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public bool Update(Category entity)
        {
            int result = _categoryDAL.Update(entity);

            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
