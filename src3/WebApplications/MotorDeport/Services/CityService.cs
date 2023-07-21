using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Services;

public interface ICityService
{
	List<CityModel> GetAllCities();
	List<CityShortInfoModel> GetAvailableCities();
	CityModel CreateCity(CityModel city);
	bool DeleteCity(Guid id);
}

public class CityService : ICityService
{
	private readonly MotorDeportContext _context;

	public CityService(MotorDeportContext context = null)
	{
		this._context = context ?? new MotorDeportContext();
	}

	public List<CityModel> GetAllCities() 
	{
		return this.SelectCities().ToList();
	}
	
	public List<CityShortInfoModel> GetAvailableCities()
	{
		return this._context.City.Select(x => new CityShortInfoModel()
		{
			Id = x.Id,
			Name = x.Name
		}).ToList();
	}


	public CityModel CreateCity(CityModel city)
	{
		city.Id = new Guid();
		this._context.Add(new City(city.Name, city.Id));
		this._context.SaveChanges();
		return city;
	}

	public bool DeleteCity(Guid id)
	{
		var city = this._context.City.FirstOrDefault(p => p.Id == id);
		if (city == null) return false;

		this._context.City.Remove(city);
		this._context.SaveChanges();
		return true;
	}


	private IQueryable<CityModel> SelectCities()
	{
		return this._context.City.Select(x => new CityModel()
		{
			Id = x.Id,
			Name = x.Name
		});
	}
}