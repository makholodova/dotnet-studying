using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class DriverController : Controller
{
	private readonly IDriverService _driverService;

	public DriverController(IDriverService driverService)
	{
		this._driverService = driverService;
	}

	public IActionResult Index()
	{
		var drivers = this._driverService.GetAllDrivers().ToList();
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
		this._driverService.CreateDriver(driver);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		this._driverService.DeleteDriver(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Work(Guid id)
	{
		this._driverService.ChangeWork(id, true);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult NotWork(Guid id)
	{
		this._driverService.ChangeWork(id, false);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var driverModel = this._driverService.GetDriverById(id);
		return this.View(driverModel);
	}

	[HttpPost]
	public IActionResult Update(DriverModel driver)
	{
		this._driverService.UpdateDriver(driver);
		return this.RedirectToAction("Index");
	}
}