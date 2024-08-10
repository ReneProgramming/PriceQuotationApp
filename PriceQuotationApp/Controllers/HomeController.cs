using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;
using System.Diagnostics;

namespace PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new PriceQuotationModel()); 
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model); // Return the model with calculated values
            }
            else
            {
                return View(model); // Return with validation errors
            }
        }

        [HttpPost]
        public IActionResult Clear()
        {
            return RedirectToAction("Index"); 
        }
    }
}
