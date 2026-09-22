using Microsoft.AspNetCore.Mvc;

namespace Chapter2MVC.Controllers
{
    public class HomeController : Controller
    {
        /*public string Index()
        {
            return "Welcome to Chapter 2 MVC!";
        }*/
        //IActionResult --> it returns the view file
        public IActionResult Index()
        {
            return View();
        }
    }
}