namespace MotorDeport.Models;

public class TripUpdateModel
{
	public DateTime Time { get; set; }
	public Guid Id { get; set; }
	public Guid FromCityId { get; set; }
	public Guid ToCityId { get; set; }
	public Guid DriverId { get; set; }
	public Guid CarId { get; set; }
}