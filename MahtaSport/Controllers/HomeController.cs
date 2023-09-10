using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MahtaSport.Models;

namespace MahtaSport.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private string? contact;
    private readonly List<kindofyoo> _kind = new List<kindofyoo>
    {
        new kindofyoo
        {
            image="sssss",
            name = "e1",
            text= "lorm oposum"

        },
        new kindofyoo
        {
            image="sssss",
            name = "e2",
            text= "lorm oposum"

        },
        new kindofyoo
        {
            image="sssss",
            name = "e3",
            text= "lorm oposum"

        },
        new kindofyoo
        {
            image="sssss",
            name = "e4",
            text= "lorm oposum"

        }
    };

 public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var cantact = new Contact()
       
        {
            Maile = "mahdieh.tarikhchi@gmail.com",
            Mobile = "09381248141",
            Address = "mashhad"
        };
        
        return View(_kind);
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

