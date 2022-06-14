namespace ClassOOP.N_9_Animal
{
	public abstract class Animal
	{
		public string Name { get; private set; }
		public int Identifier { get; private set; }
		public  double CountOfFood { get;  set; }
		public TypeOfFood TypeOfFood { get; private set; }

		public Animal(string name, int identifier,double countOfFood,TypeOfFood typeOfFood)
		{
			Name = name;
			Identifier = identifier;
			CountOfFood = countOfFood;
			TypeOfFood = typeOfFood;

		}

		public abstract double AmountOfFood();
		public abstract void Print();
	}
}