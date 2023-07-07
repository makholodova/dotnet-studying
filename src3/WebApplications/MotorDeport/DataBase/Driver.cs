namespace MotorDeport.DataBase;

public class Driver
{
	/*private Driver()
	{
	}*/

	public Driver(string name, bool isWork, Guid id)
	{
		this.Name = name;
		this.IsWork = isWork;
		this.Id = id;
	}

	public string Name { get; set; }
	public bool IsWork { get; set; }
	public Guid Id { get; set; }
	public List<Trip> Trips { get; set; }
}