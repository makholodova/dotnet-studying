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
			var sum = Num1 + Num2;
			Console.WriteLine($"Сумма чисел = {sum}");
			return sum;
		}

		public int GetMaxValue()
		{
			var max = Num2;
			if (Num1 >= Num2)
			{
				max = Num1;
			}

			Console.WriteLine($"Наибольшее число: {max}");
			return max;
		}

		public void ChangeCalculator(int num1, int num2)
		{
			Num1 = num1;
			Num2 = num2;
		}

		public void PrintContent()
		{
			Console.WriteLine($"Первое число: {Num1}; Второе число: {Num2}");
			//Console.WriteLine($"Сумма чисел = {Addition()}; наибольшее число: {GetMaxValue()}");
		}
	}
}