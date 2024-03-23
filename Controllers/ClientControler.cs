using Microsoft.AspNetCore.Mvc;

namespace CarService.Controllers
{
    public class ClientControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
