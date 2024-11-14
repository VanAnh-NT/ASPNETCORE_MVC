using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["messageVD"] = "Du lieu trong ViewData";
            ViewBag.messageVB = "Du lieu trong VB";
            TempData["messageTD"] = "Du lieu luu trong TemData";
            return View();
        }
        public IActionResult GetAllProduct()
        {
            ViewData["messageVD"] = "Du lieu trong ViewData";
            ViewBag.messageVB = "Du lieu trong VB";
            TempData["messageTD"] = "Du lieu luu trong TemData";
            return View("Product"); }
        public IActionResult GetProduct() {
            Product p = new Product { 
                ProductId = 1,
                ProductName = "Test",
                YearRealease = 2024,
                Price = 3
                
            };
            ViewBag.product = p;
            ViewData["productVD"]= p;
            return View();

        }
    }
}
