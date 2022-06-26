using System;
using System.Linq;

namespace ClassOOP.Bayer
{
	public class BayerEntryPoint : IEntryPoint

	{
		public void Start()
		{
			var products = new Product[10];

			var orange = new Fruit("Апельсин", TypeOfFruit.Citrus);
			var tomato = new Vegetable("Помидор", TypeOfVegetable.Tomatoes);
			var sizeScarletSails = new Size(100, 250);
			var scarletSails = new Book("Алые паруса", 125, sizeScarletSails);
			var peach = new Fruit("Персик", TypeOfFruit.StoneFruit);
			var blueberry = new Fruit("Голубика", TypeOfFruit.Berry);
			var sizeHarryPotter = new Size(150, 200);
			var harryPotter = new Book("Гарри Поттер", 650, sizeHarryPotter);
			var sizeGoneWithTheWind = new Size(180, 300);
			var goneWithTheWind = new Book("Унесенные ветром", 350, sizeGoneWithTheWind);
			var potato = new Vegetable("Картофель", TypeOfVegetable.Roots);
			var arugula = new Vegetable("Руккола", TypeOfVegetable.Leafy);

			

			var p = products.FirstOrDefault(x => x.Name == "");
			

		}
	}
}