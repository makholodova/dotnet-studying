using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Services;

public interface IDriverService
{
	List<DriverModel> GetAllDrivers();
	List<DriverShortInfoModel> GetAvailableDrivers();
	DriverModel GetDriverById(Guid id);
	DriverModel CreateDriver(DriverModel driver);
	bool DeleteDriver(Guid id);
	bool ChangeWork(Guid id, bool isWork);
	bool UpdateDriver(DriverModel driver);
}

public class DriverService : IDriverService
{
	private readonly MotorDeportContext _context;

	public DriverService(MotorDeportContext context)
	{
		this._context = context;
	}

	public List<DriverModel> GetAllDrivers()
	{
		return this.SelectDrivers().ToList();
	}

	public List<DriverShortInfoModel> GetAvailableDrivers()
	{
		return this._context.Driver
			.Where(x => x.IsWork)
			.Select(x => new DriverShortInfoModel
			{
				Id = x.Id,
				Name = x.Name
			}).ToList();
	}

	public DriverModel GetDriverById(Guid id)
	{
		return this.SelectDrivers().FirstOrDefault(driver => driver.Id == id);
	}

	public DriverModel CreateDriver(DriverModel driver)
	{
		driver.Id = Guid.NewGuid();
		driver.IsWork = true;
		this._context.Driver.Add(new Driver(driver.Name, driver.IsWork, driver.Id));
		this._context.SaveChanges();
		return driver;
	}

	public bool DeleteDriver(Guid id)
	{
		var driver = this._context.Driver.FirstOrDefault(driver => driver.Id == id);
		if (driver == null) return false;

		this._context.Driver.Remove(driver);
		this._context.SaveChanges();
		return true;
	}

	public bool ChangeWork(Guid id, bool isWork)
	{
		var driver = this._context.Driver.FirstOrDefault(driver => driver.Id == id);
		if (driver == null) return false;

		driver.IsWork = isWork;
		this._context.SaveChanges();
		return true;
	}

	public bool UpdateDriver(DriverModel driver)
	{
		var driverDb = this._context.Driver.FirstOrDefault(driverDb => driverDb.Id == driver.Id);
		if (driverDb == null) return false;

		driverDb.Name = driver.Name;
		driverDb.IsWork = driver.IsWork;
		this._context.SaveChanges();
		return true;
	}

	private IQueryable<DriverModel> SelectDrivers()
	{
		return this._context.Driver.Select(x => new DriverModel
		{
			Id = x.Id,
			Name = x.Name,
			IsWork = x.IsWork,
			IsOnTrip = x.Trips.Any()
		});
	}
}