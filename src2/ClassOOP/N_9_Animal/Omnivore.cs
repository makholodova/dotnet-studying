using System;

namespace ClassOOP.N_9_Animal
{
	public class Omnivore : Animal
	{
		public double Water { get; private set; }
		public double Vegetable { get; private set; }
		public double Meat { get; private set; }

		public Omnivore(string name, int identifier, double water, double vegetable, double meat) : base(name, identifier)
		{
			Water = water;
			Vegetable = vegetable;
			Meat = meat;
		}

		public override double AmountOfFood()
		{
			return Water + Vegetable + Meat;
		}

		public override void Print()
		{
			Console.WriteLine(
				$"Всеядное животное {Name}, идентификатор  животного {Identifier}, тип и количество потребляемой пищи:" +
				$" \r\n Вода - {Water};" +
				$" \r\n Овощи - {Vegetable};" +
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