using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class DriverController : Controller
{
	public IActionResult Index()
	{
		var drivers = new List<DriverModel>();
		foreach (var driver in MotorDeportDb.Drivers)
		{
			var driverModel = ConvertToDriverModel(driver);
			drivers.Add(driverModel);
		}

		return View(drivers);
	}

	private static DriverModel ConvertToDriverModel(Driver driver)
	{
		var isOnTrip = MotorDeportDb.Trips.Any(x => x.DriverId == driver.Id);
		var driverModel = new DriverModel
			{ Name = driver.Name, Id = driver.Id, IsWork = driver.IsWork, IsOnTrip = isOnTrip };
		return driverModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		return View();
	}

	[HttpPost]
	public IActionResult Create(DriverModel driver)
	{
		MotorDeportDb.Drivers.Add(new Driver(driver.Name, true, Guid.NewGuid()));
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		// var driver = MotorDeportDb.Drivers.First(driver => driver.Id == id);
		MotorDeportDb.Drivers.RemoveAll(driver => driver.Id == id);
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Work(Guid id)
	{
		var driver = MotorDeportDb.Drivers.First(driver => driver.Id == id);
		driver.IsWork = true;
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult NotWork(Guid id)
	{
		var driver = MotorDeportDb.Drivers.First(driver => driver.Id == id);
		driver.IsWork = false;

		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var driver = MotorDeportDb.Drivers.First(driver => driver.Id == id);
		var driverModel = ConvertToDriverModel(driver);
		return View(driverModel);
	}

	[HttpPost]
	public IActionResult Update(DriverModel driver)
	{
		var driverDb = MotorDeportDb.Drivers.First(driverDb => driverDb.Id == driver.Id);
		driverDb.Name = driver.Name;
		driverDb.IsWork = driver.IsWork;
		return RedirectToAction("Index");
	}
}