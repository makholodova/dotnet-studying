namespace ClassOOP.Buyer
{
	public class Vegetable : Product
	{
		public TypeOfVegetable TypeOfVegetable { get; private set; }

		public Vegetable(string name, TypeOfVegetable typeOfVegetable) : base(name)
		{
			TypeOfVegetable = typeOfVegetable;
		}
	}
}