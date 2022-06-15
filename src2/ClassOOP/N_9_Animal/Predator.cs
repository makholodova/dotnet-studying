using System;

namespace ClassOOP.N_9_Animal
{
	public class Predator : Animal
	{
		public double Water { get; private set; }
		public double Meat { get; private set; }

		public Predator(string name, int identifier, double water, double meat) : base(name, identifier)
		{
			Water = water;
			Meat = meat;
		}

		public override double AmountOfFood()
		{
			return Water + Meat;
		}

		public override void Print()
		{
			Console.WriteLine($"Хищник {Name}, идентификатор  животного {Identifier}, тип и количество потребляемой пищи:" +
			                  $" \r\n Вода - {Water};" +
			                  $" \r\n Мясо - {Meat};" +
			                  $" \r\n Общее колличество еды - {AmountOfFood()}");
		}

		public override void PrintName()
		{
			Console.Write($" {Name}, ");
		}

		public override void PrintID()
		{
			Console.Write($" {Identifier}, ");
		}
	}
}