namespace MotorDeport.DataBase;

public class Car
{
    public Car(bool isWork, string model, int number, Guid id)
    {
        IsWork = isWork;
        Model = model;
        Number = number;
        Id = id;
    }

    public bool IsWork { get; }
    public string Model { get; }
    public int Number { get; }
    public Guid Id { get; }
}