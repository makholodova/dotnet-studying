using System;

namespace ClassOOP.N_3
{
	public class Calculator
	{
		public int Num1 { get; private set; }
		public int Num2 { get; private set; }

		public Calculator(int num1, int num2)
		{
			Num1 = num1;
			Num2 = num2;
		}

		public int Addition()
		{
			return Num1 + Num2;
		}

		public int GreaterThan()
		{
			if (Num1 > Num2)
			{
				return Num1;
			}

			if (Num1 == Num2)
			{
				Console.WriteLine("Числа равны");
			}

			return Num2;
		}

		public void ChangeCalculator(int num1, int num2)
		{
			Num1 = num1;
			Num2 = num2;
		}

		public void PrintContent()
		{
			Console.WriteLine($"Сумма чисел = {Addition()}; наибольшее число: {GreaterThan()}");
		}
	}
}

