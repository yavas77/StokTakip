using AutoMapper;
using StokTakip.Business.Concrete.DTOs.Categories;
using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Concrete.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, AddCategoryDTO>().ReverseMap();
        }
    }
}
