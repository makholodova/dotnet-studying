using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class CarController : Controller
{
	public IActionResult Index()
	{
		var carService = new CarService();
		var cars = carService.GetAllCars();
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
		var carService = new CarService();
		carService.CreateCar(car);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		var carService = new CarService();
		carService.DeleteCar(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult PutOnRepair(Guid id)
	{
		var carService = new CarService();
		carService.ChangeOfRepair(id, false);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult RemoveFromRepair(Guid id)
	{
		var carService = new CarService();
		carService.ChangeOfRepair(id, true);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var carService = new CarService();
		var carModel = carService.GetCarById(id);
		return this.View(carModel);
	}

	[HttpPost]
	public IActionResult Update(CarModel car)
	{
		var carService = new CarService();
		carService.UpdateCar(car);
		return this.RedirectToAction("Index");
	}
}