using System;

namespace OOP.Bag
{
	public class Bag
	{
		public int ThisIsField;
		public int ThisIsProperty { get; set; }

		public Color Color { get; set; }
		public int Volume { get; set; }
		public int PocketsCount { get; set; }
		public Book[] Books { get; set; }
		public Pen[] Pens { get; set; }
		public Pencil[] Pencils { get; set; }
		public Notebook[] Notebooks { get; set; }

		public static int SlingsCount { get; set; } // значение шарится между всеми экземплярами Bag

		private int ChangesCount { get; set; }

		public void ChangeVolumeAndPocketsCount(int volume, int pocketsCount)
		{
			Volume = volume;
			PocketsCount = pocketsCount;
			ChangesCount++;
		}

		public void PrintContent()
		{
			Console.WriteLine($"[Changes:{ChangesCount}] Рюкзак цвета {Color}, объемом {Volume}, " +
			                  $"с числом отделов {PocketsCount} содержит {Books.Length} книг, " +
			                  $"{Notebooks.Length} тетрадей(и), {Pens.Length} ручек(ки) и {Pencils.Length} карандашей");
		}

        /// <summary>
        /// Этот метод работает ТОЛЬКО со статическими полями и свойствами
        /// </summary>
        public static void PrintStaticContent()
		{
			Console.WriteLine($"Количество ручек {SlingsCount}");
		}
	}
}