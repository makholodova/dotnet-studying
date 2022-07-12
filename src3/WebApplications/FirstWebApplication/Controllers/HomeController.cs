using System.Diagnostics;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using FirstWebApplication.Models;

namespace FirstWebApplication.Controllers;

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

    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = DateTime.Now.ToString(CultureInfo.InvariantCulture)});
    }
}