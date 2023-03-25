using Microsoft.AspNetCore.Mvc;

namespace BillyGameCenter.Controllers
{
    public class UserController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}