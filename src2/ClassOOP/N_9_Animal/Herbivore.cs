using System;

namespace ClassOOP.N_9_Animal
{
	public class Herbivore : Animal
	{
		public double Water { get; private set; }
		public double Vegetable { get; private set; }

		public Herbivore(string name, int identifier, double water, double vegetable) : base(name, identifier)
		{
			Water = water;
			Vegetable = vegetable;
		}

		public override double AmountOfFood()
		{
			return Water + Vegetable;
		}

		public override void Print()
		{
			Console.WriteLine($"Травоядное животное {Name}, идентификатор  животного {Identifier}, тип и количество потребляемой пищи:" +
			                  $"  \r\n Вода - {Water};" +
			                  $"  \r\n Овощи - {Vegetable};" +
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