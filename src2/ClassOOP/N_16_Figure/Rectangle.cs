using System;

namespace ClassOOP.N_16_Figure
{
	public class Rectangle : Figure

	{
		public double Side1 { get; private set; }
		public double Side2 { get; private set; }

		public Rectangle(double side1, double side2)
		{
			Side1 = side1;
			Side2 = side2;
		}

		public override double CalculateArea()
		{
			return Side1 * Side2;
		}

		public override double CalculatePerimeter()
		{
			return 2 *(Side1 + Side2) ;
		}

		public override void Print()
		{
			Console.WriteLine($"Фигура: прямоугольник, со сторонами {Side1}, {Side2}; площадь {CalculateArea()}; периметр {CalculatePerimeter()} ");
		}

		
	}
}