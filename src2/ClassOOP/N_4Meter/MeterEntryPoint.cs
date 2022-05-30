using System;

namespace ClassOOP.N_4Meter
{
	public class MeterEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var meter1 = new Meter();
			Operation(meter1);
			var meter2 = new Meter(50, 15, 85);
			Operation(meter2);
		}

		private static void Operation(Meter meter)
		{
			meter.PrintCurrentState();
			while (true)
			{
				Console.WriteLine("Введите опреацию уменьшенния '-' , увеличения '+' , узнать текущее состояние '='");
				var oper = Console.ReadLine();
				switch (oper)
				{
					case "+":
						meter.Increase();
						break;
					case "-":
						meter.Decrease();
						break;
					case "=":
						meter.PrintCurrentState();
						break;
					default:
						meter.PrintCurrentState();
						return;
				}


				/*if (oper == "+")
				{
					meter.Increase();
				}

				else if (oper == "-")
				{
					meter.Decrease();
				}

				else if (oper == "=")
				{
					meter.PrintCurrentState();
				}
				else
				{
					meter.PrintCurrentState();
					break;
				}*/
			}
		}
	}
}