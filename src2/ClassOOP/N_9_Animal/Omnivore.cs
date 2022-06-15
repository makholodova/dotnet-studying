namespace ClassOOP.N_9_Animal
{
	public class Omnivore : Animal
	{
		public double WaterPerDay { get; private set; }
		public double VegetablePerDay { get; private set; }
		public double MeatPerDay { get; private set; }

		public Omnivore(string name, int identifier, double waterPerDay, double vegetablePerDay, double meatPerDay) : base(name, identifier)
		{
			WaterPerDay = waterPerDay;
			VegetablePerDay = vegetablePerDay;
			MeatPerDay = meatPerDay;
		}

		public override double AmountOfFoodPerDay()
		{
			return WaterPerDay + VegetablePerDay + MeatPerDay;
		}

		public override string ToString()
		{
			return $"Всеядное животное {Name}, идентификатор  животного {Identifier}, тип и количество потребляемой пищи:" +
			       $" \r\n Вода - {WaterPerDay};" +
			       $" \r\n Овощи - {VegetablePerDay};" +
			       $" \r\n Мясо - {MeatPerDay};";
		}
	}
}