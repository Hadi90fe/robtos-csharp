using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Twinty.Models;
using Algorithms;

namespace Twinty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

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

    public IActionResult SierpinskiTriangle(){
        SierpinskiTriangle st = new SierpinskiTriangle(new Random(777));
        ViewData["spec"] = st.GenerateVegaLiteSpec(new Point(3, 4), 10000);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
