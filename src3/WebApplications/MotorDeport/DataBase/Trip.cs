namespace MotorDeport.DataBase;

public class Trip
{
    public Trip(DateTime time, string route, Guid id, Guid idDriver, Guid idCar)
    {
        Time = time;
        Route = route;
        Id = id;
        DriverId = idDriver;
        CarId = idCar;
    }

    public DateTime Time { get; set; }
    public string Route { get; set; }
    public Guid Id { get; }
    public Guid DriverId { get; set; }
    public Guid CarId { get; set; }
}