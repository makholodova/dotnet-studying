using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return this.View();
	}

	public IActionResult Privacy()
	{
		return this.View();
	}
}