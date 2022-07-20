using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class TripController : Controller
{
    public IActionResult Index()
    {
        var trips = new List<TripModel>();
        foreach (var dbTrip in MotorDeportDb.Trips)
        {
            var tripCar = MotorDeportDb.Cars.First(car => car.Id == dbTrip.CarrId);
            var tripModel = new TripModel
            {
                Time = dbTrip.Time,
                Route = dbTrip.Route,
                DriverName = MotorDeportDb.Drivers.First(driver => driver.Id == dbTrip.DriverId).Name,
                ModelCar = tripCar.Model,
                NumberCar = tripCar.Number
            };

            trips.Add(tripModel);
        }

        return View(trips);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var tripModelGet = new TripModelGet();

        tripModelGet.Drivers = MotorDeportDb.Drivers.Select(x => new DriverModel
            {Id = x.Id, IsWork = x.IsWork, Name = x.Name}).ToList();
        tripModelGet.Cars = MotorDeportDb.Cars.Select(x => new CarModel
            {Id = x.Id, IsWork = x.IsWork, Model = x.Model, Number = x.Number}).ToList();
        return View(tripModelGet);
    }

    [HttpPost]
    public IActionResult Create(TripModelPost trip)
    {
        MotorDeportDb.Trips.Add(new Trip(trip.Time, trip.Route, Guid.NewGuid(), trip.DriverId, trip.CarId));
        //return View();
        return RedirectToAction("Index");
    }
}