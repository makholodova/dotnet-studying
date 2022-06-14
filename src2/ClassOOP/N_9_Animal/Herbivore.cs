using System;

namespace ClassOOP.N_9_Animal
{
	public class Herbivore : Animal
	{
		public Herbivore(string name, int identifier, double countOfFood, TypeOfFood typeOfFood) : base(name, identifier, countOfFood, typeOfFood)
		{
		}

		public override double AmountOfFood()
		{
			switch (TypeOfFood)
			{
				case TypeOfFood.DryFood:
					CountOfFood *= 100;
					break;

				case TypeOfFood.RawFood:
					CountOfFood *= 300;
					break;

				case TypeOfFood.Water:
					CountOfFood *= 50;
					break;
			}

			return CountOfFood;
		}

		public override void Print()
		{
			Console.WriteLine($"Травоядное животное,идентификатор  животного {Identifier}, имя {Name}, тип и количество потребляемой пищи {TypeOfFood} {AmountOfFood()}");
			
		}
	}
}