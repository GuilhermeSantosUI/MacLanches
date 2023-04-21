using Microsoft.AspNetCore.Mvc;
namespace maclanches.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
