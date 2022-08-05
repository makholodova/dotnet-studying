namespace MotorDeport.Models;

public class TripIndexModel
{
    public DateTime Time { get; set; }
    public string Route { get; set; }
    public string DriverName { get; set; }

    public string ModelCar { get; set; }

    public int NumberCar { get; set; }
    public Guid Id { get; set; }
}