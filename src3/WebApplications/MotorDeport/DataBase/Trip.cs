namespace MotorDeport.DataBase;

public class Trip
{
	private Trip()
	{
	}

	public Trip(DateTime time, string route, Guid id, Guid idDriver, Guid idCar)
	{
		this.Time = time;
		this.Route = route;
		this.Id = id;
		this.DriverId = idDriver;
		this.CarId = idCar;
	}

	public Guid Id { get; set; }
	public DateTime Time { get; set; }
	public string Route { get; set; }

	public Guid CarId { get; set; }
	public Car Car { get; set; }

	public Guid DriverId { get; set; }
	public Driver Driver { get; set; }
}