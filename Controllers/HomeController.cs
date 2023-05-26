using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp1.Models;

namespace WebApp1.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private const string SQLConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

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
