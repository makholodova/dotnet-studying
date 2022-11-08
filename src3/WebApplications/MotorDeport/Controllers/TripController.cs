using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class TripController : Controller
{
	public IActionResult Index()
	{
		var trips = new List<TripIndexModel>();
		foreach (var dbTrip in MotorDeportDb.Trips)
		{
			var tripModel = ConvertToTripModel(dbTrip);
			trips.Add(tripModel);
		}

		return View(trips);
	}

	private static TripIndexModel ConvertToTripModel(Trip dbTrip)
	{
		var tripCar = MotorDeportDb.Cars.First(car => car.Id == dbTrip.CarId);
		var tripModel = new TripIndexModel
		{
			Time = dbTrip.Time,
			Route = dbTrip.Route,
			DriverName = MotorDeportDb.Drivers.First(driver => driver.Id == dbTrip.DriverId).Name,
			ModelCar = tripCar.Model,
			NumberCar = tripCar.Number,
			Id = dbTrip.Id
		};
		return tripModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		var tripModelGet = new TripCreateModelGet();
		tripModelGet.Drivers = MotorDeportDb.Drivers.Select(x => new DriverModel
			{ Id = x.Id, IsWork = x.IsWork, Name = x.Name }).ToList();
		tripModelGet.Cars = MotorDeportDb.Cars.Select(x => new CarModel
			{ Id = x.Id, IsWork = x.IsWork, Model = x.Model, Number = x.Number }).ToList();
		return View(tripModelGet);
	}

	[HttpPost]
	public IActionResult Create(TripCreateModelPost tripCreate)
	{
		MotorDeportDb.Trips.Add(new Trip(tripCreate.Time, tripCreate.Route, Guid.NewGuid(), tripCreate.DriverId,
			tripCreate.CarId));

		return RedirectToAction("Index");
	}

	public IActionResult Delete(Guid id)
	{
		var trip = MotorDeportDb.Trips.First(trip => trip.Id == id);
		MotorDeportDb.Trips.Remove(trip);
		return RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var trip = MotorDeportDb.Trips.First(trip => trip.Id == id);
		var drivers = MotorDeportDb.Drivers.Select(x =>
			new DriverModel { Id = x.Id, IsWork = x.IsWork, Name = x.Name }).ToList();
		var cars = MotorDeportDb.Cars.Select(x =>
			new CarModel { IsWork = x.IsWork, Model = x.Model, Number = x.Number, Id = x.Id }).ToList();
		var tripUpdateModelGet = new TripUpdateModelGet
		{
			Drivers = drivers,
			Cars = cars,
			Time = trip.Time,
			Route = trip.Route,
			Id = trip.Id,
			DriverId = trip.DriverId,
			CarId = trip.CarId
		};
		return View(tripUpdateModelGet);
	}

	[HttpPost]
	public IActionResult Update(TripUpdateModelPost trip)
	{
		var tripDb = MotorDeportDb.Trips.First(tripDb => tripDb.Id == trip.Id);
		tripDb.Route = trip.Route;
		tripDb.Time = trip.Time;
		tripDb.CarId = trip.CarId;
		tripDb.DriverId = trip.DriverId;

		return RedirectToAction("Index");
	}
}