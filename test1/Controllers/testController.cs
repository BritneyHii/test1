using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
