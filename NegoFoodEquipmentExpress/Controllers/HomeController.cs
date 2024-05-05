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
                new Product { Name = "Mini Donut Maker Electric", Description = "Indulge in sweet, homemade treats with our Electric Mini Donut Maker. This compact and easy-to-use appliance allows you to bake delicious mini donuts in minutes.", Price = 600, ImagePath = "minidonutec.jpg" },
                new Product { Name = "Meat Bowl Cutter", Description = "Effortlessly prepare perfectly minced meat with our Meat Bowl Cutter. This professional-grade appliance is designed for high-volume meat processing, making it ideal for commercial kitchens and food establishments. Its powerful motor and sharp blades ensure quick and efficient cutting, saving you time and effort.", Price = 84999, ImagePath = "meatbowlcutter.jpg" },
                new Product { Name = "Pedal Sealing Machine", Description = "Seal your food and packaging with ease using our Pedal Sealing Machine. This efficient and convenient machine allows you to seal bags and packages quickly and effectively. With its pedal-operated design, you can keep both hands free for handling items, making it perfect for high-volume sealing tasks. ", Price = 5499, ImagePath = "pedalsealingmachine.jpg" },
                new Product { Name = "Spice Herb Grinder", Description = "Enhance the flavor of your dishes with our Spice Herb Grinder. This handy tool allows you to grind spices and herbs with ease, ensuring maximum flavor in every meal. Its compact size makes it perfect for kitchen use, and its durable construction ensures long-lasting performance.", Price = 9990, ImagePath = "spiceherbgrinder.jpg" },

            };

            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult RequestQuote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestQuote(RequestQuoteViewModel model)
        {
            // Process the form submission (e.g., send an email, save to database)
            // Redirect to a thank you page or return a view
            return RedirectToAction("Index");
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
