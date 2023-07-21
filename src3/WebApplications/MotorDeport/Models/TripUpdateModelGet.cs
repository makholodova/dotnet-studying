namespace MotorDeport.Models;

public class TripUpdateModelGet
{
	public TripModel Trip { get; set; }
	public List<CarShortInfoModel> Cars { get; set; }
	public List<DriverShortInfoModel> Drivers { get; set; }
	public List<CityShortInfoModel> Cities { get; set; }
}