using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View(MobileContext.Phones);
	}

	[HttpGet]
	public IActionResult Buy(int? id)
	{
		if (id == null) return RedirectToAction("Index");

		ViewBag.PhoneId = id;
		return View();
	}

	[HttpPost]
	public string Buy(Order order)
	{
		MobileContext.Orders.Add(order);
		return "Спасибо, " + order.User + ", за покупку!";
	}
}