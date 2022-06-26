namespace ClassOOP.Bayer
{
	public class Fruit : Product
	{
		public TypeOfFruit TypeOfFruit { get; private set; }

		public Fruit(string name, TypeOfFruit typeOfFruit) : base(name)
		{
			TypeOfFruit = typeOfFruit;
		}
	}
}