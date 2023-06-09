using System;

namespace OOP.Garden;

public class Plant
{
	public string Name { get; set; }
	public TypeOfPlant TypePlant { get; set; }
	public int Count { get; set; }

	public override string ToString()
	{
		return $"Name plant: {Name}, Type is {TypePlant}, Count is {Count}";
	}
}