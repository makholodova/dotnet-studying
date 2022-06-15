namespace ClassOOP.N_9_Animal
{
	public abstract class Animal
	{
		public string Name { get; private set; }
		public int Identifier { get; private set; }

		public Animal(string name, int identifier)
		{
			Name = name;
			Identifier = identifier;
		}

		public abstract double AmountOfFood();
		public abstract void Print();
		public abstract void PrintName();
		public abstract void PrintID();
	}
}