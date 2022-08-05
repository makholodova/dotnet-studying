namespace MotorDeport.Models;

public class TripCreateModelPost
{
    public DateTime Time { get; set; }
    public string Route { get; set; }
    public Guid DriverId { get; set; }
    public Guid CarId { get; set; }
}