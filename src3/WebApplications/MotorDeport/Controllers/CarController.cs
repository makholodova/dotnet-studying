using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class CarController : Controller
{
	public IActionResult Index()
	{
		var cars = new List<CarModel>();
		foreach (var car in MotorDeportDb.Cars)
		{
			var carModel = ConvertToCarModel(car);
			cars.Add(carModel);
		}

		return View(cars);
	}

	private static CarModel ConvertToCarModel(Car car)
	{
		var isOnTrip = MotorDeportDb.Trips.Any(trip => trip.CarId == car.Id);
		var carModel = new CarModel
			{ Id = car.Id, Model = car.Model, Number = car.Number, IsWork = car.IsWork, IsOnTrip = isOnTrip };
		return carModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		return View();
	}

	[HttpPost]
	public IActionResult Create(CarModel car)
	{
		MotorDeportDb.Cars.Add(new Car(true, car.Model, car.Number, Guid.NewGuid()));
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		MotorDeportDb.Cars.RemoveAll(car => car.Id == id);
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult PutOnRepair(Guid id)
	{
		var car = MotorDeportDb.Cars.First(car => car.Id == id);
		car.IsWork = false;
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult RemoveFromRepair(Guid id)
	{
		var car = MotorDeportDb.Cars.First(car => car.Id == id);
		car.IsWork = true;
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var car = MotorDeportDb.Cars.First(car => car.Id == id);
		var carModel = ConvertToCarModel(car);
		return View(carModel);
	}

	[HttpPost]
	public IActionResult Update(CarModel car)
	{
		var carDb = MotorDeportDb.Cars.First(carDb => carDb.Id == car.Id);
		carDb.Number = car.Number;
		carDb.IsWork = car.IsWork;
		return RedirectToAction("Index");
	}
}