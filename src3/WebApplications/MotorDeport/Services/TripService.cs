using MotorDeport.DataBase;
using MotorDeport.Models;

namespace MotorDeport.Services;

public interface ITripService
{
	List<TripIndexModel> GetAllTrips();
	TripModel GetTripById(Guid id);
	TripCreateModel CreateTrip(TripCreateModel tripCreate);
	bool UpdateTrip(TripUpdateModel trip);
	bool DeleteTrip(Guid id);
}

public class TripService : ITripService
{
	private readonly MotorDeportContext _context;

	public TripService(MotorDeportContext context = null)
	{
		this._context = context ?? new MotorDeportContext();
	}

	public List<TripIndexModel> GetAllTrips()
	{
		return this.SelectTrips().ToList();
	}

	public TripModel GetTripById(Guid id)
	{
		var trip = this._context.Trip.FirstOrDefault(trip => trip.Id == id);
		if (trip == null) return null;

		var tripModel = new TripModel
		{
			Time = trip.Time,
			FromCityId = trip.FromCityId,
			ToCityId = trip.ToCityId,
			Id = trip.Id,
			DriverId = trip.DriverId,
			CarId = trip.CarId
		};
		return tripModel;
	}

	public TripCreateModel CreateTrip(TripCreateModel tripCreate)
	{
		tripCreate.Id = Guid.NewGuid();
		this._context.Trip.Add(new Trip(tripCreate.Time, tripCreate.FromCityId, tripCreate.ToCityId, tripCreate.Id, tripCreate.DriverId,
			tripCreate.CarId));
		this._context.SaveChanges();
		return tripCreate;
	}

	public bool UpdateTrip(TripUpdateModel trip)
	{
		var tripDb = this._context.Trip.FirstOrDefault(tripDb => tripDb.Id == trip.Id);
		if (tripDb == null) return false;

		tripDb.ToCityId = trip.ToCityId;
		tripDb.FromCityId = trip.FromCityId;
		tripDb.Time = trip.Time;
		tripDb.CarId = trip.CarId;
		tripDb.DriverId = trip.DriverId;

		this._context.SaveChanges();
		return true;
	}

	public bool DeleteTrip(Guid id)
	{
		var trip = this._context.Trip.FirstOrDefault(trip => trip.Id == id);
		if (trip == null) return false;

		this._context.Trip.Remove(trip);
		this._context.SaveChanges();
		return true;
	}
	
	private IQueryable<TripIndexModel> SelectTrips()
	{
		return this._context.Trip.Select(dbTrip => new TripIndexModel
		{
			Time = dbTrip.Time,
			FromCity = dbTrip.FromCity.Name,
			ToCity = dbTrip.ToCity.Name,
			DriverName = dbTrip.Driver.Name,
			ModelCar = dbTrip.Car.Model,
			NumberCar = dbTrip.Car.Number,
			Id = dbTrip.Id
		});
	}
}