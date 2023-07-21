using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class TripController : Controller
{
	private readonly ITripService _tripService;
	private readonly ICarService _carService;
	private readonly IDriverService _driverService;
	private readonly ICityService _cityService;

	public TripController(ITripService tripService, ICarService carService, IDriverService driverService, ICityService cityService)
	{
		this._tripService = tripService;
		this._carService = carService;
		this._driverService = driverService;
		this._cityService = cityService;
	}


	public IActionResult Index()
	{
		var trips = this._tripService.GetAllTrips();
		return this.View(trips);
	}

	[HttpGet]
	public IActionResult Create()
	{
		var tripModelGet = new TripCreateModelGet();

		tripModelGet.Cars = this._carService.GetAvailableCars();
		tripModelGet.Drivers = this._driverService.GetAvailableDrivers();
		tripModelGet.Cities = this._cityService.GetAvailableCities();

		return this.View(tripModelGet);
	}

	[HttpPost]
	public IActionResult Create(TripCreateModel tripCreate)
	{
		this._tripService.CreateTrip(tripCreate);
		return this.RedirectToAction("Index");
	}

	public IActionResult Delete(Guid id)
	{
		this._tripService.DeleteTrip(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var tripModelGet = new TripUpdateModelGet();

		tripModelGet.Trip = this._tripService.GetTripById(id);
		tripModelGet.Cars = this._carService.GetAvailableCars();
		tripModelGet.Drivers = this._driverService.GetAvailableDrivers();
		tripModelGet.Cities = this._cityService.GetAvailableCities();

		return this.View(tripModelGet);
	}

	[HttpPost]
	public IActionResult Update(TripUpdateModel trip)
	{
		this._tripService.UpdateTrip(trip);
		return this.RedirectToAction("Index");
	}
}