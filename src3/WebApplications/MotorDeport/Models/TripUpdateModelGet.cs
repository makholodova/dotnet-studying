namespace MotorDeport.Models;

public class TripUpdateModelGet
{
	public List<DriverModel> Drivers { get; set; }
	public List<CarModel> Cars { get; set; }
	public DateTime Time { get; set; }
	public string Route { get; set; }
	public Guid Id { get; set; }
	public Guid DriverId { get; set; }
	public Guid CarId { get; set; }
}