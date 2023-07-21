using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Services;

public interface ICarService
{
	List<CarModel> GetAllCars();
	List<CarShortInfoModel> GetAvailableCars();
	CarModel GetCarById(Guid id);
	bool UpdateCar(CarModel newCar);
	bool ChangeOfRepair(Guid id, bool isWork);
	CarModel CreateCar(CarModel car);
	bool DeleteCar(Guid id);
}

public class CarService : ICarService
{
	private readonly MotorDeportContext _context;

	public CarService(MotorDeportContext context)
	{
		this._context = context;
	}

	public List<CarModel> GetAllCars()
	{
		return this.SelectCars().ToList();
	}

	public List<CarShortInfoModel> GetAvailableCars()
	{
		return this._context.Car
			.Where(x => x.IsWork)
			.Select(x => new CarShortInfoModel
			{
				Id = x.Id,
				Model = x.Model
			}).ToList();
	}

	public CarModel GetCarById(Guid id)
	{
		return this.SelectCars().FirstOrDefault(x => x.Id == id);
	}

	public bool UpdateCar(CarModel newCar)
	{
		var carDb = this._context.Car.FirstOrDefault(carDb => carDb.Id == newCar.Id);
		if (carDb == null)
			return false;

		carDb.Number = newCar.Number;
		carDb.IsWork = newCar.IsWork;
		this._context.SaveChanges();
		return true;
	}

	public bool ChangeOfRepair(Guid id, bool isWork)
	{
		var car = this._context.Car.FirstOrDefault(x => x.Id == id);
		if (car == null) return false;

		car.IsWork = isWork;
		this._context.SaveChanges();
		return true;
	}

	public CarModel CreateCar(CarModel car)
	{
		car.Id = new Guid();
		car.IsWork = true;
		this._context.Car.Add(new Car(car.IsWork, car.Model, car.Number, car.Id));
		this._context.SaveChanges();
		return car;
	}

	public bool DeleteCar(Guid id)
	{
		var car = this._context.Car.FirstOrDefault(x => x.Id == id);
		if (car == null) return false;

		this._context.Car.Remove(car);
		this._context.SaveChanges();
		return true;
	}

	private IQueryable<CarModel> SelectCars()
	{
		return this._context.Car.Select(x => new CarModel
		{
			Id = x.Id,
			Model = x.Model,
			Number = x.Number,
			IsWork = x.IsWork,
			IsOnTrip = x.Trips.Any()
		});
	}
}