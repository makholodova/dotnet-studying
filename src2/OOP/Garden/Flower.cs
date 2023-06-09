namespace OOP.Garden;

public class Flower
{
	public string Name { get; set; }
	public Color Color { get; set; }
	public int Count { get; set; }

	public override string ToString()
	{
		return $"Name flower: {Name}, Color is {Color}, Count is {Count}";
	}
}