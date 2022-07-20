namespace MotorDeport.DataBase;

public class Driver
{
    public Driver(string name, bool isWork, Guid id)
    {
        Name = name;
        IsWork = isWork;
        Id = id;
    }

    public string Name { get; }
    public bool IsWork { get; }
    public Guid Id { get; }
}