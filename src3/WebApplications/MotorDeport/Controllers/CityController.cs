using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class CityController : Controller
{
	private readonly ICityService _cityService;

	public CityController(ICityService cityService)
	{
		this._cityService = cityService;
	}

	public IActionResult Index()
	{
		var cities = this._cityService.GetAllCities();
		return this.View(cities);
	}


	public IActionResult Delete(Guid id)
	{
		this._cityService.DeleteCity(id);
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
		this._cityService.CreateCity(city);
		return this.RedirectToAction("Index");
	}
}