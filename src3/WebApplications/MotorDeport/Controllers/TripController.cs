using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class TripController : Controller
{
	public IActionResult Index()
	{
		using var context = new MotorDeportContext();
		var trips = new List<TripIndexModel>();
		foreach (var dbTrip in context.Trip)
		{
			var tripModel = ConvertToTripModel(dbTrip);
			trips.Add(tripModel);
		}

		return this.View(trips);
	}

	private static TripIndexModel ConvertToTripModel(Trip dbTrip)
	{
		//using var context = new MotorDeportContext();
		
		//var tripCar = context.Car.First(car => car.Id == dbTrip.CarId);
		var tripModel = new TripIndexModel
		{
			Time = dbTrip.Time,
			Route = dbTrip.Route,
			DriverName = dbTrip.Driver.Name,//context.Driver.First(driver => driver.Id == dbTrip.DriverId).Name,
			ModelCar = dbTrip.Car.Model,
			NumberCar = dbTrip.Car.Number,
			Id = dbTrip.Id
		};
		return tripModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		using var context = new MotorDeportContext();
		var tripModelGet = new TripCreateModelGet();
		tripModelGet.Drivers = context.Driver.Select(x => new DriverModel
			{ Id = x.Id, IsWork = x.IsWork, Name = x.Name }).ToList();
		tripModelGet.Cars = context.Car.Select(x => new CarModel
			{ Id = x.Id, IsWork = x.IsWork, Model = x.Model, Number = x.Number }).ToList();
		return this.View(tripModelGet);
	}

	[HttpPost]
	public IActionResult Create(TripCreateModelPost tripCreate)
	{
		using var context = new MotorDeportContext();
		context.Trip.Add(new Trip(tripCreate.Time, tripCreate.Route, Guid.NewGuid(), tripCreate.DriverId,
			tripCreate.CarId));
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	public IActionResult Delete(Guid id)
	{
		using var context = new MotorDeportContext();
		var trip = context.Trip.First(trip => trip.Id == id);
		context.Trip.Remove(trip);
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		using var context = new MotorDeportContext();
		var trip = context.Trip.First(trip => trip.Id == id);
		var drivers = context.Driver.Select(x =>
			new DriverModel { Id = x.Id, IsWork = x.IsWork, Name = x.Name }).ToList();

		var cars = context.Car.Select(x =>
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
		return this.View(tripUpdateModelGet);
	}

	[HttpPost]
	public IActionResult Update(TripUpdateModelPost trip)
	{
		using var context = new MotorDeportContext();
		var tripDb = context.Trip.First(tripDb => tripDb.Id == trip.Id);
		tripDb.Route = trip.Route;
		tripDb.Time = trip.Time;
		tripDb.CarId = trip.CarId;
		tripDb.DriverId = trip.DriverId;
		context.SaveChanges();
		return this.RedirectToAction("Index");
	}
}