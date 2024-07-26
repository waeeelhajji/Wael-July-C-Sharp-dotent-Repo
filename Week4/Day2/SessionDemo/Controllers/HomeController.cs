using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //!Making Session
        //? String
        // HttpContext.Session.SetString("UserName", "Wael Hajji");
        //? Number 
        // HttpContext.Session.SetInt32("Num", 5);
        return View();
    }
    [HttpPost("Login")]
    public IActionResult Login(string Name, int Num)

    {

        HttpContext.Session.SetString("UserName", Name);
        HttpContext.Session.SetInt32("Number", Num);
        return RedirectToAction("Privacy");

    }

    public IActionResult Privacy()
    {
        //1
        string UserName = HttpContext.Session.GetString("UserName");
        //2
        int? Number = HttpContext.Session.GetInt32("Number");

        if (UserName == null)
        {
            return RedirectToAction("Index");

        }
        return View();
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
