using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;
using Alchemy;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Alchemy.Services;

namespace Alchemy.Controllers;


public class CreateRobotRequest
{
    public int id;
    public string nom;
    public int poids;
    public string pays;
}


public class RobotController : Controller
{

    private readonly ILogger<RobotController> _logger;
    private IAddRobotService addRobotService;
    public RobotController(ILogger<RobotController> logger, IAddRobotService addRobotService)
    {
        _logger = logger;
        this.addRobotService = addRobotService;
    }

    // POST: /Robot/Add
    [HttpPost]
    public IActionResult Add(string nom, int poids, string pays)
    {
        string messageResp;
        // Process the form data here
        if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(poids.ToString()) && !string.IsNullOrEmpty(pays))
        {
            // Save data to a database, perform some action, etc.
            addRobotService.CreateRobot(nom, poids.ToString(), pays);
            // Return JSON or any response as needed
            // var res = Json(new { success = true, message = "Robot added successfully" });
            messageResp = "Robot added successfully";
        }
        else
        {
            // If data is not valid, return an error message
            // return Json(new { success = false, message = "Invalid data" });
            messageResp = "Invalid data";
        }

        ViewData["message"] = messageResp;
        return RedirectToAction("Index", "Home");
    }

    // POST: /Robot/Remove
    [HttpPost]
    public IActionResult Remove(int id)
    {
        // Process the form data here
        addRobotService.DeleteRobot(id);
        // Return JSON or any response as needed
        // return Json(new { success = true, message = "Robot Deleted successfully" });
        ViewData["message"] = "Robot Deleted successfully";
        return RedirectToAction("Index", "Home");
    }

}

