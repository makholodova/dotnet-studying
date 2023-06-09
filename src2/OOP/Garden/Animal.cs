namespace OOP.Garden;

public class Animal
{
	public string Name { get; set; }
	public Color Color { get; set; }
	public int CountLegs { get; set; }
	public int Count { get; set; }

	public override string ToString()
	{
		return $"Name animal: {Name}, Color is {Color}, count of animal legs are {CountLegs}, Count animals are {Count}";
	}
}