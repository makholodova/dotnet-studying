using System;

namespace Calculator
{
	public static class ConsoleHelper
	{
		public static bool ShouldContinue()
		{
			while (true)
			{
				Console.WriteLine("Продолжить? true or false");
				var str = Console.ReadLine();
				if (str == null)
				{
					continue;
				}

				var isParsed = bool.TryParse(str, out var shouldContinue);
				//isParsed-возвращает true or false  в значение
				//распарсил или нет;
				//var shouldContinue - присваивает true or false в
				//зависимости от введенной str;
				if (!isParsed)
				{
					continue;
				}

				return shouldContinue;
			}
		}

		public static double EnterValue()
		{
			while (true)
			{
				Console.WriteLine("Введите значение");
				var numStr = Console.ReadLine();
				if (numStr == null)
				{
					continue;
				}

				var isParsed = double.TryParse(numStr, out var num);
				if (!isParsed)
				{
					continue;
				}

				return num;
			}
		}

		public static char EnterOperator()
		{
			while (true)
			{
				Console.WriteLine("Введите оператор");
				var str = Console.ReadLine();
				if (str.Length > 1)
				{
					continue;
				}

				var sign = str[0];
				var operators = "-+*/";
				for (var i = 0; i < operators.Length; i++)
				{
					if (sign == operators[i])
					{
						return sign;
					}
				}
			}
		}

		public static void PrintResult(double res)
		{
			Console.WriteLine($"Результат: {res}");
		}
	}
}