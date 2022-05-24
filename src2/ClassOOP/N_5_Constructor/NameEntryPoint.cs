using System;

namespace ClassOOP.N_5_Constructor
{
	public class NameEntryPoint : IEntryPoint
	{
		public void Start()
		{
			Console.WriteLine("Start");

			// using вызывает метод Dispose когда код выходит за пределы фигурной скобки --> } 
			using (var name1 = new Name())
			{
				var name2 = new Name("Рома", "Холодов");

				var fn = name1.FirstName;
				//name1.FirstName = "Рома"; неправильно

				name1.ChangeName("Angelina", "Joli");

				name1.Print();
				name2.Print();
			}

			Console.WriteLine("Finish");
		}
	}
}