using System;

namespace ClassOOP.N_2_Train
{
	public class TrainEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var trains = CreateTrains();
			TrainPrintContent(trains);
			Console.WriteLine("Упорядочить по номерам поездов ");
			SortByTrainNumber(trains);
			TrainPrintContent(trains);
			Console.WriteLine("Инфомация о запрашиваемом поезде (0-остановить) ");
			TrainInformation(trains);
			Console.WriteLine("Упорядочить по по пункту назначения ");
            SortByTrainDestinationName(trains);
		    TrainPrintContent(trains);

			// var g = trains[1].TimeLeave.ToShortTimeString();
		}

		private static void TrainInformation(Train[] trains)
		{
			while (true)
			{
				Console.WriteLine("Введите номер поезда ");
				var numSrt = Console.ReadLine();
				var number = int.Parse(numSrt);
				if (number == 0)
				{
					break;
				}

				for (var i = 0; i < trains.Length; i++)
				{
					if (number == trains[i].TrainNumber)
					{
						trains[i].PrintContent();
					}
				}
			}
		}

		private static void SortByTrainNumber(Train[] trains)
		{
			for (var i = 0; i < trains.Length; i++)
			{
				for (var j = 0; j < trains.Length - i - 1; j++)
				{
					var train1 = trains[j];
					var trainNumber1 = train1.TrainNumber;
					var train2 = trains[j + 1];
					var trainNumber2 = train2.TrainNumber;
					if (trainNumber1 > trainNumber2)
					{
						trains[j] = train2;
						trains[j + 1] = train1;
					}
				}
			}
		}

		private static void SortByTrainDestinationName(Train[] trains)
		{
			for (var i = 0; i < trains.Length; i++)
			{
				for (var j = 0; j < trains.Length - i - 1; j++)
				{
					var train1 = trains[j];
					var trainDestinationName1 = train1.DestinationName;
					var train2 = trains[j + 1];
					var trainDestinationName2 = train2.DestinationName;
					var isFirstName = string.Compare(trainDestinationName1, trainDestinationName2); // <0 < то a<b;0- то a=b, или length =0;>0 - то a>b.
					if (isFirstName > 0) 
					{
						trains[j] = train2;
						trains[j + 1] = train1;
					}
					if (isFirstName == 0)
					{
						SortByTimeLeave(trains, train1, train2, j);
					}
					
				}
			}
		}

		private static void SortByTimeLeave(Train[] trains, Train train1, Train train2, int j)
		{
			var trainTimeLeave1 = train1.TimeLeave;
			var trainTimeLeave2 = train2.TimeLeave;
			var isFirstTime = DateTime.Compare(trainTimeLeave1, trainTimeLeave2);
			if (isFirstTime > 0)
			{
				trains[j] = train2;
				trains[j + 1] = train1;
			}
		}

		private static void TrainPrintContent(Train[] trains)
		{
			for (var i = 0; i < trains.Length; i++)
			{
				trains[i].PrintContent();
			}
		}

		private static Train[] CreateTrains()

		{
			var trains = new Train[5];
			trains[0] = new Train
			{
				DestinationName = "Moscow",
				TrainNumber = 2,
				TimeLeave = new DateTime(2022, 05, 20, 15, 30, 0)
			};
			trains[1] = new Train
			{
				DestinationName = "Krasnodar",
				TrainNumber = 4,
				TimeLeave = new DateTime(2022, 06, 04, 08, 45, 0)
			};
			trains[2] = new Train
			{
				DestinationName = "Sochi",
				TrainNumber = 1,
				TimeLeave = new DateTime(2022, 07, 09, 17, 25, 0)
			};
			trains[3] = new Train
			{
				DestinationName = "Moscow",
				TrainNumber = 5,
				TimeLeave = new DateTime(2022, 06, 23, 13, 10, 0)
			};
			trains[4] = new Train
			{
				DestinationName = "Krasnodar",
				TrainNumber = 3,
				TimeLeave = new DateTime(2022, 07, 18, 11, 45, 0)
			};
			return trains;
		}
	}
}