using BethanysPieShopAdmin.Models.Repositories;
using BethanysPieShopAdmin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BethanysPieShopAdmin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;   

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            CategoryViewModel viewModel = new()
            {
                Categories = (await _categoryRepository.GetAllCategoriesAsync()).ToList()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var selectedCategory = await _categoryRepository.GetCategoryByIdAsync(id.Value);
            return View(selectedCategory);

        }

    }
}
