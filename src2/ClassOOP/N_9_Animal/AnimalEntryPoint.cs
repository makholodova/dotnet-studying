namespace ClassOOP.N_9_Animal
{
	public class AnimalEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var animals = new Animal[3];
			animals[0] = new Herbivore("Корова", 265, 1, TypeOfFood.DryFood);
			animals[1] = new Predator("Тигр", 123, 1, TypeOfFood.Water);
			animals[2] = new Omnivore("Енот", 123, 1, TypeOfFood.RawFood);
			foreach (var animal in animals)
			{
				animal.Print();
			}
		}
	}
}