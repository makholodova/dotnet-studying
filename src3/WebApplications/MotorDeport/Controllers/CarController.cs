using Microsoft.AspNetCore.Mvc;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class CarController : Controller
{
	private readonly ICarService _carService;

	public CarController(ICarService carService)
	{
		this._carService = carService;
	}

	public IActionResult Index()
	{
		var cars = this._carService.GetAllCars();
		return this.View(cars);
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(CarModel car)
	{
		this._carService.CreateCar(car);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		this._carService.DeleteCar(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult PutOnRepair(Guid id)
	{
		this._carService.ChangeOfRepair(id, false);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult RemoveFromRepair(Guid id)
	{
		this._carService.ChangeOfRepair(id, true);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var carModel = this._carService.GetCarById(id);
		return this.View(carModel);
	}

	[HttpPost]
	public IActionResult Update(CarModel car)
	{
		this._carService.UpdateCar(car);
		return this.RedirectToAction("Index");
	}
}