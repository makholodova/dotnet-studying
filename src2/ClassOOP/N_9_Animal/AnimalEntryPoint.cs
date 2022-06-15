using System;

namespace ClassOOP.N_9_Animal
{
	public class AnimalEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var animals = new Animal[8];
			animals[0] = new Omnivore("Енот", 587, 4, 5, 2);
			animals[1] = new Herbivore("Корова", 265, 120, 30);
			animals[2] = new Predator("Тигр", 123, 35, 60);
			animals[3] = new Herbivore("Коза", 173, 30, 8);
			animals[4] = new Predator("Крокодил", 084, 40, 55);
			animals[5] = new Omnivore("Собака", 015, 2, 5, 2);
			animals[6] = new Herbivore("Слон", 317, 218, 80);
			animals[7] = new Predator("Дятел", 213, 3, 2);

			SertByAmountOfFood(animals);

			foreach (var animal in animals)
			{
				Console.WriteLine($"{animal.ToString()} \r\n Общее колличество еды - {animal.AmountOfFoodPerDay()}");
			}

			Console.WriteLine($"Вывод первых 5 имен животных из списка: ");
			for (var i = 0; i < 5; i++)
			{
				Console.Write($" {animals[i].Name},");
			}

			Console.WriteLine($" \r\nВывод последних 3 ID животных из списка: ");
			for (var i = animals.Length - 1; i >= 5; i--)
			{
				Console.Write($" {animals[i].Identifier},");
			}
		}

		private static void SertByAmountOfFood(Animal[] animals)
		{
			for (var i = 0; i < animals.Length; i++)
			{
				for (var j = 0; j < animals.Length - i - 1; j++)
				{
					var animal1 = animals[j];
					var amountOfFoodPerDay1 = animal1.AmountOfFoodPerDay();
					var animal2 = animals[j + 1];
					var amountOfFoodPerDay2 = animal2.AmountOfFoodPerDay();
					if (amountOfFoodPerDay1 > amountOfFoodPerDay2)
					{
						animals[j] = animal2;
						animals[j + 1] = animal1;
						continue;
					}

					if (amountOfFoodPerDay1 == amountOfFoodPerDay2)
					{
						SortByName(animals, animal1, animal2, j);
					}
				}
			}
		}

		private static void SortByName(Animal[] animals, Animal animal1, Animal animal2, int j)
		{
			var animalName1 = animal1.Name;
			var animalName2 = animal2.Name;
			var isFirstName = string.Compare(animalName1, animalName2);
			if (isFirstName > 0)
			{
				animals[j] = animal2;
				animals[j + 1] = animal1;
			}
		}
	}
}