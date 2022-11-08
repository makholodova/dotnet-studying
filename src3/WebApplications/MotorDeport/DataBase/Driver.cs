namespace MotorDeport.DataBase;

public class Driver
{
	public Driver(string name, bool isWork, Guid id)
	{
		Name = name;
		IsWork = isWork;
		Id = id;
	}

	public string Name { get; set; }
	public bool IsWork { get; set; }
	public Guid Id { get; }
}