using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers {
    public class PieController : Controller {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository) {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Index() {
            ViewBag.Message = "Welcome to Bethany's Pie Shop";
            return View();
        }

        public ViewResult List() {
            PiesListViewModel pieListViewModel = new PiesListViewModel();

            pieListViewModel.Pies = _pieRepository.AllPies;
            pieListViewModel.CurrentCategory = "Cheese Cakes";

            return View(pieListViewModel);
        }
    }
}