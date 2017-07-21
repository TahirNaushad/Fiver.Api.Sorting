using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.Sorting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Get", "Movies");
        }
    }
}
