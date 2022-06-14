using System;

namespace ClassOOP.N_9_Animal
{
	public class Predator : Animal
	{
		public Predator(string name, int identifier, double countOfFood, TypeOfFood typeOfFood) : base(name, identifier, countOfFood, typeOfFood)
		{
		}

		public override double AmountOfFood()
		{
			switch (TypeOfFood)
			{
				case TypeOfFood.DryFood:
					CountOfFood *= 20;
					break;

				case TypeOfFood.RawFood:
					CountOfFood *= 150;
					break;

				case TypeOfFood.Water:
					CountOfFood *= 80;
					break;
			}

			return CountOfFood;
		}

		public override void Print()
		{
			Console.WriteLine($"Хищник, идентификатор  животного {Identifier}, имя {Name}, тип и количество потребляемой пищи: ");
			switch (TypeOfFood)
			{
				case TypeOfFood.DryFood:
					Console.WriteLine($"{TypeOfFood} {AmountOfFood()}");
					break;

				case TypeOfFood.RawFood:
					Console.WriteLine($"{TypeOfFood} {AmountOfFood()}");
					break;

				case TypeOfFood.Water:
					Console.WriteLine($"{TypeOfFood} {AmountOfFood()}");
					break;
			}
		}
	}
}