namespace MotorDeport.Models;

public class TripCreateModelGet
{
	public List<CarShortInfoModel> Cars { get; set; }
	public List<DriverShortInfoModel> Drivers { get; set; }
	public List<CityShortInfoModel> Cities { get; set; }
}