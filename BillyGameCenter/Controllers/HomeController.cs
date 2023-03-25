using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BillyGameCenter.Models;

namespace BillyGameCenter.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [HeaderActionFilter(RedirectAction = "Index", RedirectController = "User")]
    public IActionResult Index()
    {
        ViewBag.NowTime = DateTime.Now;
        ViewBag.hereWeGoAgain = "Hello Bitch";
        _logger.LogDebug("Just Debug Test");
        return View();
    }

    [TypeFilter(typeof(BackendAuthFilter))]
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