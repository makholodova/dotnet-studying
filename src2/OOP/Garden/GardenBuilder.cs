namespace OOP.Garden;

public static class GardenBuilder
{
	public static Garden Build()
	{
		var garden = new Garden();
		garden.Area = 160;
		garden.Address = "Nikolaeva_11";
		garden.Size = new Size
			{ Wight = 8, Length = 20 };

		garden.Animals = GetAnimals();
		
		garden.Plants = GetPlants();
		garden.Flowers= GetFlowers();
		return garden;
	}

	private static Flower[] GetFlowers()
	{
		var flower1 = new Flower() {Name = "Rosa", Color =Color.Orange, Count = 15};
		var flower2 = new Flower() {Name = "Romashka", Color =Color.White, Count = 35};
		var flower3 = new Flower() {Name = "Tulpan", Color =Color.Yellow, Count = 17};
		var flower4 = new Flower() {Name = "Mak", Color =Color.Red, Count = 12};
		var flowers = new[] {flower1,flower2,flower3,flower4 };
		return flowers;
	}

	private static Plant[] GetPlants()
	{
		var plant1 = new Plant() { Count = 5, Name = "Apple", TypePlant = TypeOfPlant.tree };
		var plant2 = new Plant() { Count = 8, Name = "Jasmine", TypePlant = TypeOfPlant.shrub };
		var plant3 = new Plant() { Name = "Rucola", TypePlant = TypeOfPlant.grass };
		var plants = new[] { plant1, plant2, plant3 };
		return plants;
	}

	private static Animal[] GetAnimals()
	{
		var animal1 = new Animal()
		{
			Name = "Cat", Color = Color.Brown, Count = 2
		};
		var animal2 = new Animal()
			{ Name = "Dod", Color = Color.Black, Count = 1 };

		var animals = new[]
			{ animal1, animal2 };
		return animals;
	}
}