using System;

namespace ClassOOP.N_4Meter
{
	public class Meter
	{
		public int Value { get; private set; }
		public int MinValue { get; private set; }
		public int MaxValue { get; private set; }

		public Meter()
		{
			Value = 0;
			MinValue = 0;
			MaxValue = 100;
		}

		public Meter(int value, int minValue, int maxValue)
		{
			Value = value;
			MinValue = minValue;
			MaxValue = maxValue;
		}

		public int Increase()
		{
			Value++;
			if (Value > MaxValue)
			{
				Value = MaxValue;
			}

			return Value;
		}

		public int Decrease()
		{
			Value--;
			if (Value < MinValue)
			{
				Value = MinValue;
			}

			return Value;
		}

		public void PrintCurrentState()
		{
			Console.WriteLine($"Текущее состояние: значение счетчика {Value},мнимальное значение {MinValue}, максимальное значение {MaxValue} ");
		}
	}
}