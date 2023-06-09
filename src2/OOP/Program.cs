using System;
using OOP.Flat;
using OOP.Garden;

namespace OOP
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			/* var bag = BagBuilder.Build();
			 bag.ChangeVolumeAndPocketsCount(50, 4);
			 bag.PrintContent();
			 bag.ChangeVolumeAndPocketsCount(55,4);
			 bag.PrintContent();*/

			//var flat = FlatBuilder.Build();
			var garden =  GardenBuilder.Build();
			Console.WriteLine(garden.ToString());
			
		}
	}
}