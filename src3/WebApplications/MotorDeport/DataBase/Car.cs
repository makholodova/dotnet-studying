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

	public bool IsWork { get; set; }
	public string Model { get; set; }
	public int Number { get; set; }
	public Guid Id { get; }
}