using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PluralsightAspNetCore.Services;
using PluralsightAspNetCore.ViewModels;

namespace PluralsightAspNetCore.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieReponsitory _pieReponsitory; 
        private readonly ICategoryRepository _categoryRepository; 
        public PieController(IPieReponsitory pieReponsitory, ICategoryRepository categoryRepository)
        {
            _pieReponsitory = pieReponsitory;
            _categoryRepository = categoryRepository;            
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieReponsitory.Pies;

            ViewBag.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }
    }
}
