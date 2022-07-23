using CoffeeShopsProducts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopsProducts.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeProductDBContext context = new CoffeeProductDBContext();


        public IActionResult Index()
        {
            List<Product> result = context.Products.ToList();
            return View(result);
        }

        public IActionResult Detail(int productId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == productId);
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
