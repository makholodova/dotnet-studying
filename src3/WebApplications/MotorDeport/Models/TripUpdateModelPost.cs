namespace MotorDeport.Models;

public class TripUpdateModelPost
{
    public DateTime Time { get; set; }
    public string Route { get; set; }
    public Guid Id { get; set; }
    public Guid DriverId { get; set; }
    public Guid CarId { get; set; }
}