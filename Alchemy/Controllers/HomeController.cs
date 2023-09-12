using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;
using System.Reflection.Metadata.Ecma335;

namespace Alchemy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    List<Robot> robots;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        robots = new List<Robot>();
        robots.Add(new Robot("Bob", "35", "Gabon"));
        robots.Add(new Robot("Alice", "25", "Canada"));
        robots.Add(new Robot("Audrei", "35", "Algerie"));
        robots.Add(Robot.GetRobotByNameWithRandomInfos(null));
    }

    public Robot? GetRobotByName(string Name)
    {
        foreach (Robot r in robots)
        {
            if (r.nom == Name)
            {
                return r;
            }

        };
        // If no robot with the given name is found, return null
        return null;
    }



    public IActionResult Index()
    {
        ViewData["robots"] = robots;
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
