using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp1.Models;
using WebApp1.Service;

namespace WebApp1.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;   
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        constosoDBService = new ConstosoDBService();
    }

    private readonly ConstosoDBService constosoDBService;

    public IActionResult Index()
    {

        this.Request.Headers.TryGetValue("username", out var customerName);
        constosoDBService.LogUserExist(customerName);


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
