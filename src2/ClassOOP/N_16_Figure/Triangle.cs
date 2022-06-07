using System;

namespace ClassOOP.N_16_Figure
{
	public class Triangle : Figure
	{
		public double Side1 { get; private set; }
		public double Side2 { get; private set; }
		public double Side3 { get; private set; }

		public Triangle(double side1, double side2, double side3)
		{
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
		}

		public override double CalculateArea()
		{
			var p = CalculatePerimeter();
			return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
		}

		public override double CalculatePerimeter()
		{
			return (Side1 + Side2 + Side3) / 2;
		}

		public override void Print()
		{
			Console.WriteLine($"Фигура: треугольник  со сторонами {Side1},{Side2}, {Side3}; площадь {CalculateArea()}; периметр {CalculatePerimeter()} ");
		}
	}
}