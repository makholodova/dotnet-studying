using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;
using MotorDeport.Services;

namespace MotorDeport.Controllers;

public class TripController : Controller
{
	public IActionResult Index()
	{
		var tripService = new TripService();
		var trips = tripService.GetAllTrips();
		return this.View(trips);
	}

	[HttpGet]
	public IActionResult Create()
	{
		var carService = new CarService();
		var driverService = new DriverService();
		var cityService = new CityService();
		
		var tripModelGet = new TripCreateModelGet();

		tripModelGet.Cars = carService.GetAvailableCars();
		tripModelGet.Drivers = driverService.GetAvailableDrivers();
		tripModelGet.Cities = cityService.GetAvailableCities();

		return this.View(tripModelGet);
	}

	[HttpPost]
	public IActionResult Create(TripCreateModel tripCreate)
	{
		var tripService = new TripService();
		tripService.CreateTrip(tripCreate);
		return this.RedirectToAction("Index");
	}

	public IActionResult Delete(Guid id)
	{
		var tripService = new TripService();
		tripService.DeleteTrip(id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var carService = new CarService();
		var driverService = new DriverService();
		var cityService = new CityService();
		var tripService = new TripService();

		var tripModelGet = new TripUpdateModelGet();
		
		tripModelGet.Trip = tripService.GetTripById(id);
		tripModelGet.Cars = carService.GetAvailableCars();
		tripModelGet.Drivers = driverService.GetAvailableDrivers(); 
		tripModelGet.Cities = cityService.GetAvailableCities(); 
		
		return this.View(tripModelGet);
	}

	[HttpPost]
	public IActionResult Update(TripUpdateModel trip)
	{
		var tripService = new TripService();
		tripService.UpdateTrip(trip);
		return this.RedirectToAction("Index");
	}
}