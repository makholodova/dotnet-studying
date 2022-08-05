using System.Collections;

namespace MotorDeport.Models;

public class DriverModel 
{
    public string Name { get; set; }
    public bool IsWork { get; set; }
    public Guid Id { get; set; }
    public bool IsOnTrip { get; set; }
   
}