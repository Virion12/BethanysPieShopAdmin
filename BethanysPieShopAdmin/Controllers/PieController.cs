using BethanysPieShopAdmin.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BethanysPieShopAdmin.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public async Task<IActionResult> Index()
        {
            var pies = await _pieRepository.GetAllPiesAsync();
            return View(pies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var pie = await _pieRepository.GetPieById(id);
            return View(pie);
        }
    }
}
