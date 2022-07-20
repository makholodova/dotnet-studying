namespace MotorDeport.DataBase;

public class Trip
{
    public Trip(DateTime time, string route, Guid id, Guid idDriver, Guid idCar)
    {
        Time = time;
        Route = route;
        Id = id;
        DriverId = idDriver;
        CarrId = idCar;
    }

    public DateTime Time { get; }
    public string Route { get; }
    public Guid Id { get; }
    public Guid DriverId { get; }
    public Guid CarrId { get; }
}