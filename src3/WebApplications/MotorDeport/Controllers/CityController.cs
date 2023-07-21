using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class CityController : Controller
{
	public IActionResult Index()
	{
		var cityService = new CityService();
		var cities = cityService.GetAllCities();
		return this.View(cities);
	}


	public IActionResult Delete(Guid id)
	{
		var cityService = new CityService();
		cityService.DeleteCity(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(CityModel city)
	{
		var cityService = new CityService();
		cityService.CreateCity(city);
		return this.RedirectToAction("Index");
	}
}