namespace MotorDeport.DataBase;

public class Car
{
	/*private Car()
	{
	}*/

	public Car(bool isWork, string model, int number, Guid id)
	{
		this.IsWork = isWork;
		this.Model = model;
		this.Number = number;
		this.Id = id;
	}

	public bool IsWork { get; set; }
	public string Model { get; set; }
	public int Number { get; set; }
	public Guid Id { get; set; }
	public List<Trip> Trips { get; set; }
}