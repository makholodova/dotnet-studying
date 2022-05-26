using System;

namespace ClassOOP.N_3
{
	public class CalculatorEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var num1 = CreateNum();
			var num2 = CreateNum();
			var calculator1 = new Calculator(num1, num2);
			calculator1.Addition();
			calculator1.GreaterThan();
			calculator1.PrintContent();
			var num3 = CreateNum();
			var num4 = CreateNum();
			calculator1.ChangeCalculator(num3,num4);
			calculator1.PrintContent();
		}

		private static int CreateNum()
		{
			var numStr = Console.ReadLine();
			var num = int.Parse(numStr);
			return num;
		}
	}
}