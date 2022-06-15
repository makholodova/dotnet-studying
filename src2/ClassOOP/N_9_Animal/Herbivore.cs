namespace ClassOOP.N_9_Animal
{
	public class Herbivore : Animal
	{
		public double WaterPerDay { get; private set; }
		public double VegetablePerDay { get; private set; }

		public Herbivore(string name, int identifier, double waterPerDay, double vegetablePerDay) : base(name, identifier)
		{
			WaterPerDay = waterPerDay;
			VegetablePerDay = vegetablePerDay;
		}

		public override double AmountOfFoodPerDay()
		{
			return WaterPerDay + VegetablePerDay;
		}

		public override string ToString() //почему override
		{
			return $"Травоядное животное {Name}, идентификатор  животного {Identifier}, тип и количество потребляемой пищи:" +
			       $"  \r\n Вода - {WaterPerDay};" +
			       $"  \r\n Овощи - {VegetablePerDay};";
		}
	}
}