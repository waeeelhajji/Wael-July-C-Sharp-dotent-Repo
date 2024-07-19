using Microsoft.AspNetCore.Mvc; //? This is a service that brings in our MVC functionality
namespace FirstWeb.Controllers; //? be sure to use your own project's namespace!

public class HelloController : Controller //? remember inheritance ??
{
    //!-----------------------------------Routing 
    //! This tells our controller we have a web page we want to see (or GET)
    [HttpGet]
    //? What is url?
    //? this goes to localhost:5XXX/
    [Route("")]
    public string CsIndex()
    {
        return "Hello from our Controller";
    }

    [HttpGet("user/more")]
    public string User()
    {
        return "More Info About the user";
    }
    [HttpGet("user/{id}")]
    public string UserId(int id)
    {
        return $"this is the user {id}";
    }

    [HttpGet("/Dash")]
    public ViewResult Index()
    {
        ViewBag.name = "Wael";
        ViewBag.number = 7;
        return View();
    }

    [HttpPost("process")]
    // public RedirectResult Process(string FavoriteAnimal)
    public IActionResult Process(string FavoriteAnimal)
    {
        if (FavoriteAnimal == "dog")
        {
            ViewBag.name = "Wael";
            ViewBag.number = 7;
            ViewBag.Error = "Dogs are great but you need to pick another animal";
            return View("Index");
        }


        Console.WriteLine(FavoriteAnimal);

        return RedirectToAction("Suceess");

    }
    [HttpGet("/Suceess")]
    public ViewResult Suceess()
    {

        return View();
    }





}
