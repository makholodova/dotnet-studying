namespace MotorDeport.Models;

public class CarModel
{
    public bool IsWork { get; set; }
    public string Model { get; set; }
    public int Number { get; set; }
    public Guid Id { get; set; }
    public bool IsOnTrip { get; set; }
}