namespace MotorDeport.DataBase;

public class City
{
	public City(string name, Guid id)
	{
		this.Name = name;
		this.Id = id;
	}

	

	public string Name { get; set; }
	public Guid Id { get; set; }
	public List<Trip> FromTrips { get; set; }
	public List<Trip> ToTrips { get; set; }
}