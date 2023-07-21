using MotorDeport.DataBase;

namespace MotorDeport.Models;

public class TripIndexModel
{
	public DateTime Time { get; set; }
	public string FromCity { get; set; }
	public string ToCity { get; set; }
	public string DriverName { get; set; }

	public string ModelCar { get; set; }

	public int NumberCar { get; set; }
	public Guid Id { get; set; }
	
}