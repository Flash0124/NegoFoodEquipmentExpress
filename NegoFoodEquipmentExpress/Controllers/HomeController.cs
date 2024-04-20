using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NegoFoodEquipmentExpress.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace NegoFoodEquipmentExpress.Controllers
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
            var products = new List<Product>
            {
                new Product { Name = "Food Warmer", Description = "Keep your delicious dishes at the perfect serving temperature.", Price = 100, ImagePath = "foodwarmer.jpg" },
                new Product { Name = "Electric Crepe Maker", Description = "Designed for convenience and precision, this sleek appliance boasts a non-stick cooking surface that ensures flawless results every time.", Price = 200, ImagePath = "eccrepemaker.jpg" },
                new Product { Name = "Siopao Siomai Steamer Electric", Description = "A must-have for any kitchen looking to effortlessly steam delicious Asian delicacies.", Price = 300, ImagePath = "siopaosiomaiecstreamer.jpg" },
                new Product { Name = "Espresso Machine", Description = "Designed for coffee enthusiasts, this machine delivers barista-quality espresso with its advanced features and sleek design.", Price = 400, ImagePath = "espressomachine.jpg" },
                new Product { Name = "Heavy Duty Meat Grinder", Description = "The perfect tool for grinding meat effortlessly and efficiently. Whether you're preparing sausages, burgers, or meatloaf, this grinder is up to the task.", Price = 500, ImagePath = "heavydutymeatgrinder.jpg" },
                new Product { Name = "Mini Donut Maker Electric", Description = "Indulge in sweet, homemade treats with our Electric Mini Donut Maker. This compact and easy-to-use appliance allows you to bake delicious mini donuts in minutes.", Price = 600, ImagePath = "minidonutec.jpg" }
            };

            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
