using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MahtaSport.Models;

namespace MahtaSport.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private string? contact;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        var cantact = new Contact()
        {
            Maile = "mahdieh.tarikhchi@gmail.com",
            Mobile = "09381248141",
            Address = "mashhad"
        };
        return View(cantact);
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Blog()
    {
        return View();
    }

    public IActionResult team()
    {
        return View();
    }

    public IActionResult Single()
    {
        return View();
    }

    public IActionResult Price()
    {
        return View();
    }
    public IActionResult Service()
    {
        return View();
    }
    public IActionResult Portfolio()
    {
        return View();
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

