using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class CategoryController : Controller
    {
        [HttpGet]   
        public IActionResult Index()
        {
            return View();
        }
    }
}
