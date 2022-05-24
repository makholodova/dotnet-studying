using System;

namespace OOP.Flat
{
	public class Furniture
	{
		public TypeOfFurniture TypeOfFurniture { get; set; }
		public Color Color { get; set; }
		public int Number { get; set; }
		public Size Size { get; set; }

		public void PrintContent()
		{
			Console.WriteLine($"Тип мебели {TypeOfFurniture}, цвет {Color}, количество {Number}, {Size}");
		}
	}
}