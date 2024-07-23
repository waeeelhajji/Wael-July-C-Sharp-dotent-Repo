using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static List<Pet> Pets = new List<Pet>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("create/pet")]
    public IActionResult Create(Pet newPet)
    {
        if (ModelState.IsValid)
        {
            Pets.Add(newPet);
            return RedirectToAction("AllPets");
        }
        else
        {
            // Render validation Errors
            return View("index");
        }
    }
    [HttpGet("AllPest")]
    public IActionResult AllPets()
    {
        return View("AllPets", Pets);
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
