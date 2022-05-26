using System;

namespace ClassOOP.N_2_Train
{
	public struct Train
	{
		public string DestinationName;
		public int TrainNumber;
		public DateTime TimeLeave;

		public void PrintContent()
		{
			Console.WriteLine($"Поезд № {TrainNumber}, пункта назначения: {DestinationName}, время отправления: {TimeLeave} ");
		}
	}
}