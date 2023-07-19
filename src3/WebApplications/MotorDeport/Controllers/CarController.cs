using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class CarController : Controller
{
	public IActionResult Index()
	{
		using var context = new MotorDeportContext();
		var cars = new List<CarModel>();
		foreach (var car in context.Car)
		{
			var carModel = ConvertToCarModel(car);
			cars.Add(carModel);
		}

		return this.View(cars);
	}

	private static CarModel ConvertToCarModel(Car car)
	{
		//using var context = new MotorDeportContext();
		//var isOnTrip = context.Trip.Any(trip => trip.CarId == car.Id);
		var isOnTrip = car.Trips.Any();
		var carModel = new CarModel
			{ Id = car.Id, Model = car.Model, Number = car.Number, IsWork = car.IsWork, IsOnTrip = isOnTrip };
		return carModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(CarModel car)
	{
		using var context = new MotorDeportContext();
		context.Car.Add(new Car(true, car.Model, car.Number, Guid.NewGuid()));
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		using var context = new MotorDeportContext();
		var car = context.Car.FirstOrDefault(x => x.Id == id);
		if (car == null) return this.RedirectToAction("Index");
		context.Car.Remove(car);
		context.SaveChanges();

		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult PutOnRepair(Guid id)
	{
		using var context = new MotorDeportContext();
		var car = context.Car.FirstOrDefault(x => x.Id == id);
		if (car == null) return this.RedirectToAction("Index");
		car.IsWork = false;
		context.SaveChanges();

		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult RemoveFromRepair(Guid id)
	{
		using var context = new MotorDeportContext();
		var car = context.Car.FirstOrDefault(x => x.Id == id);
		if (car == null) return this.RedirectToAction("Index");
		car.IsWork = true;
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		using var context = new MotorDeportContext();
		var car = context.Car.FirstOrDefault(car => car.Id == id);
		var carModel = ConvertToCarModel(car);
		return this.View(carModel);
	}

	[HttpPost]
	public IActionResult Update(CarModel car)
	{
		using var context = new MotorDeportContext();
		var carDb = context.Car.FirstOrDefault(carDb => carDb.Id == car.Id);
		if (carDb == null) return this.RedirectToAction("Index");
		carDb.Number = car.Number;
		carDb.IsWork = car.IsWork;
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}
}