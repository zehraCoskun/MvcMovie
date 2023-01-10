using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 

    public IActionResult Welcome(string name, int Id = 1)
    {
        ViewData ["Message"] = "Hello " + name;
        ViewData ["id"] = Id;
        return View();
    }

}