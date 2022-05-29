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
			meter.CurrentState();
			while (true)
			{
				Console.WriteLine("Введите опреацию уменьшенния '-' , увеличения '+' , узнать текущее состояние '='");
				var oper = Console.ReadLine();
				if (oper == "+")
				{
					meter.IncreaseValue();
				}

				else if (oper == "-")
				{
					meter.DecreaseValue();
				}

				else if (oper == "=")
				{
					meter.CurrentState();
				}
				else
				{
					meter.CurrentState();
					break;
				}
			}
		}
	}
}