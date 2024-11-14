using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class DEMOController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
