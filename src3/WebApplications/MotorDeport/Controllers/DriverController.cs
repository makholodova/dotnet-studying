using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class DriverController : Controller
{
	public IActionResult Index()
	{
		var driverService = new DriverService();
		var drivers = driverService.GetAllDrivers().ToList();
		return this.View(drivers);
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(DriverModel driver)
	{
		var driverService = new DriverService();
		driverService.CreateDriver(driver);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		var driverService = new DriverService();
		driverService.DeleteDriver(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Work(Guid id)
	{
		var driverService = new DriverService();
		driverService.ChangeWork(id, true);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult NotWork(Guid id)
	{
		var driverService = new DriverService();
		driverService.ChangeWork(id, false);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var driverService = new DriverService();
		var driverModel = driverService.GetDriverById(id);
		return this.View(driverModel);
	}

	[HttpPost]
	public IActionResult Update(DriverModel driver)
	{
		var driverService = new DriverService();
		driverService.UpdateDriver(driver);
		return this.RedirectToAction("Index");
	}
}