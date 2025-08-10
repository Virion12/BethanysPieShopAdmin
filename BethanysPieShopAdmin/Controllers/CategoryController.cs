using BethanysPieShopAdmin.Models;
using BethanysPieShopAdmin.Models.Repositories;
using BethanysPieShopAdmin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        public IActionResult Add() { 
        return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("CategoryName,Description,DateAdded")]Category category)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    await _categoryRepository.AddCategoryAsync(category);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex) {
                ModelState.AddModelError("",$"Wrong format for category: {ex.Message}");
            }

            return View(category);
           
        }

    }
}
