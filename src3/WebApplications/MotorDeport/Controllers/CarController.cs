using Microsoft.AspNetCore.Mvc;
using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Controllers;

public class CarController : Controller
{
    public IActionResult Index()
    {
        var cars = new List<CarModel>();
        foreach (var car in MotorDeportDb.Cars)
        {
            var carModel = new CarModel {Id = car.Id, Model = car.Model, Number = car.Number, IsWork = car.IsWork};
            cars.Add(carModel);
        }

        return View(cars);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CarModel car)
    {
        MotorDeportDb.Cars.Add(new Car(true, car.Model, car.Number, Guid.NewGuid()));
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(Guid id)
    {
        MotorDeportDb.Cars.RemoveAll(car => car.Id == id);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult PutOnRepair(Guid id)
    {
        var car = MotorDeportDb.Cars.First(car => car.Id == id);
           car.IsWork=false;
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult RemoveFromRepair(Guid id)
    {
        var car = MotorDeportDb.Cars.First(car => car.Id == id);
        car.IsWork=true;
        return RedirectToAction("Index");
    }

}

