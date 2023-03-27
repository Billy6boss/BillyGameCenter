using BillyGameCenter.DataAccess;
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

        public IActionResult ChatRoom()
        {
            return View();
        }
    }
}