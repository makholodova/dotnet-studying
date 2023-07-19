using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class DriverController : Controller
{
	public IActionResult Index()
	{
		using var context = new MotorDeportContext();
		var drivers = new List<DriverModel>();
		foreach (var driver in context.Driver)
		{
			var driverModel = ConvertToDriverModel(driver);
			drivers.Add(driverModel);
		}

		return this.View(drivers);
	}

	private static DriverModel ConvertToDriverModel(Driver driver)
	{
		/*using var context = new MotorDeportContext();
		var isOnTrip = context.Trip.Any(x => x.DriverId == driver.Id);*/
		var isOnTrip = driver.Trips.Any();
		var driverModel = new DriverModel
			{ Name = driver.Name, Id = driver.Id, IsWork = driver.IsWork, IsOnTrip = isOnTrip };
		return driverModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(DriverModel driver)
	{
		using var context = new MotorDeportContext();
		context.Driver.Add(new Driver(driver.Name, true, Guid.NewGuid()));
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		using var context = new MotorDeportContext();
		var driver = context.Driver.FirstOrDefault(driver => driver.Id == id);
		if (driver == null) return this.RedirectToAction("Index");
		context.Driver.Remove(driver);
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Work(Guid id)
	{
		using var context = new MotorDeportContext();
		var driver = context.Driver.First(driver => driver.Id == id);
		driver.IsWork = true;
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult NotWork(Guid id)
	{
		using var context = new MotorDeportContext();
		var driver = context.Driver.First(driver => driver.Id == id);
		driver.IsWork = false;
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		using var context = new MotorDeportContext();
		var driver = context.Driver.First(driver => driver.Id == id);
		var driverModel = ConvertToDriverModel(driver);
		return this.View(driverModel);
	}

	[HttpPost]
	public IActionResult Update(DriverModel driver)
	{
		using var context = new MotorDeportContext();
		var driverDb = context.Driver.First(driverDb => driverDb.Id == driver.Id);
		driverDb.Name = driver.Name;
		driverDb.IsWork = driver.IsWork;
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}
}