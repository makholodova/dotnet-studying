using Microsoft.AspNetCore.Mvc;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}