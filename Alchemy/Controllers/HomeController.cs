using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;
using System.Reflection.Metadata.Ecma335;
using Alchemy.Services;

namespace Alchemy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IAddRobotService addRobotService;

    public HomeController(ILogger<HomeController> logger, IAddRobotService addRobotService)
    {
        _logger = logger;
        this.addRobotService = addRobotService;
    }




    public IActionResult Index()
    {
        ViewData["robots"] = addRobotService.ListRobots();
        return View("Index");
    }
    public IActionResult AddRobot()
    {
        return View("AddRobot");
    }
    public IActionResult Bob()
    {
        Robot? robotBob = GetRobotByName("Bob");
        ViewData["robot"] = robotBob;

        return View("Robot");
    }
    public IActionResult Alice()
    {
        Robot? robotAlice = GetRobotByName("Alice");
        ViewData["robot"] = robotAlice;
        return View("Robot");
    }
    public IActionResult Audrei()
    {
        Robot? robotAudrei = GetRobotByName("Audrei");
        ViewData["robot"] = robotAudrei;
        return View("Robot");
    }
    public IActionResult Random()
    {
        Robot? randomRobot = Robot.GetRobotByNameWithRandomInfos(null);
        ViewData["robot"] = randomRobot;
        return View("Robot");
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
