using System;

namespace ClassOOP.N_16_Figure
{
	public class Circle : Figure

	{
		public double Radius { get; private set; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public override double CalculateArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}

		public override double CalculatePerimeter()
		{
			return 2 * Math.PI * Radius;
		}

		public override void Print()
		{
			Console.WriteLine($"Фигура: круг, радиусом {Radius}; площадь {CalculateArea()}; периметр {CalculatePerimeter()} ");
		}
	}
}