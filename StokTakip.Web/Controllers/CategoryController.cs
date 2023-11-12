using Microsoft.AspNetCore.Mvc;
using StokTakip.Business.Abstract;
using StokTakip.Business.Concrete.DTOs.Categories;

namespace StokTakip.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCategoryDTO addCategoryDTO)
        {
            bool result = _categoryService.Add(addCategoryDTO);

            return RedirectToAction("Index");
        }
    }
}
