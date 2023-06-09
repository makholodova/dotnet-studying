using System;

namespace OOP.Garden;

public class Size
{
	public double Wight { get; set; }
	public double Length { get; set; }

	public override string ToString()
	{
		return$"Size: {Length}x{Wight}";
	}
} 
