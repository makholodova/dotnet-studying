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
            var driverModel = new DriverModel {Name = driver.Name, Id = driver.Id, IsWork = driver.IsWork};
            drivers.Add(driverModel);
        }

        return View(drivers);
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
    {var driver = MotorDeportDb.Drivers.First(driver => driver.Id == id);
        driver.IsWork = false;
        
        return RedirectToAction("Index");
    }
   
    
}