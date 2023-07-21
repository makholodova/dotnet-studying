namespace MotorDeport.DataBase;

public class Trip
{
	public Trip()
	{
	}

	public Trip(DateTime time, Guid idFromCity, Guid idToCity, Guid id, Guid idDriver, Guid idCar)
	{
		this.Time = time;
		//this.Route = route;
		this.Id = id;
		this.DriverId = idDriver;
		this.CarId = idCar;
		this.FromCityId = idFromCity;
		this.ToCityId = idToCity;
	}

	public Guid Id { get; set; }

	public DateTime Time { get; set; }
	//public string Route { get; set; }


	public Guid CarId { get; set; }
	public virtual Car Car { get; set; }

	public Guid DriverId { get; set; }
	public virtual Driver Driver { get; set; }

	public Guid FromCityId { get; set; }
	public virtual City FromCity { get; set; }

	public Guid ToCityId { get; set; }
	public virtual City ToCity { get; set; }
}