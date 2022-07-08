using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOOP.Buyer
{
	public class BuyerEntryPoint : IEntryPoint

	{
		public void Start()
		{
			var buyer = new Buyer("Дмитрий");
			var products = CreateProducts();
			while (true)
			{
				var whatDo = WhatDo();

				switch (whatDo)
				{
					case 3:
						BuyProducts(products, buyer);
						break;
					case 2:
						BuyProduct(products, buyer);
						break;
					case 1:
						Console.WriteLine("Список покупок: ");
						PrintPurchase(buyer);
						break;
					default:
						return;
				}
			}
		}

		private static int WhatDo()
		{
			Console.WriteLine($"Что вы хотите сделать?" +
			                  $"{Environment.NewLine} - Выйти [0]" +
			                  $"{Environment.NewLine} - Распечатать все Ваши покупки[1]" +
			                  $"{Environment.NewLine} - Купить продукт[2]" +
			                  $"{Environment.NewLine} - Купить продукты[3]");
			var whatDoStr = Console.ReadLine();
			var whatDo = int.Parse(whatDoStr);
			return whatDo;
		}

		private static void BuyProduct(List<Product> products, Buyer buyer)
		{
			Console.WriteLine("Введите название продукта");
			var productStr = Console.ReadLine();
			if (productStr == null)
			{
				return;
			}

			//Сравнение ,без учета регистра
			var product = products.FirstOrDefault(x => string.Equals(x.Name, productStr, StringComparison.OrdinalIgnoreCase));
			if (product == null)
			{
				Console.WriteLine("Данный продукт временно отсутствует");
				return;
			}

			buyer.BayProduct(product);
		}

		private static void BuyProducts(List<Product> createdProducts, Buyer buyer)
		{
			Console.WriteLine("Перечислите продукты через ','");
			var productStr = Console.ReadLine();
			if (productStr == null)
			{
				return;
			}

			var enteredProductNames = productStr.Split(',');
			enteredProductNames = enteredProductNames.Select(x => x.Trim()).ToArray();

			//Сравнение ,без учета регистра
			var foundProducts = createdProducts.Where(createdProduct =>
					enteredProductNames.Any(enteredProductName =>
						string.Equals(createdProduct.Name, enteredProductName, StringComparison.OrdinalIgnoreCase)))
				.ToList();

			var unFoundProducts = enteredProductNames.Where(enteredProductName =>
					!createdProducts.Any(createdProduct => string.Equals(enteredProductName, createdProduct.Name, StringComparison.OrdinalIgnoreCase)))
				.ToList();

			if (unFoundProducts.Count != 0)
			{
				Console.WriteLine("Данные продукты временно отсутствуют:");
				foreach (var unFoundProduct in unFoundProducts)
				{
					Console.WriteLine($"{unFoundProduct.ToString()}");
				}
			}

			if (foundProducts.Count == 0)
			{
				Console.WriteLine("Покупка невозможна");
				return;
			}

			buyer.BayProducts(foundProducts);
		}

		private static void PrintPurchase(Buyer buyer)
		{
			foreach (var purchase in buyer.Purchases)
			{
				Console.WriteLine($"{purchase.ToString()}");
			}
		}

		private static List<Product> CreateProducts()
		{
			var products = new List<Product>();

			products.Add(new Fruit("Апельсин", TypeOfFruit.Citrus));
			products.Add(new Vegetable("Помидор", TypeOfVegetable.Tomatoes));
			var sizeScarletSails = new Size(100, 250);
			products.Add(new Book("Алые паруса", 125, sizeScarletSails));
			products.Add(new Fruit("Персик", TypeOfFruit.StoneFruit));
			products.Add(new Fruit("Голубика", TypeOfFruit.Berry));
			var sizeHarryPotter = new Size(150, 200);
			products.Add(new Book("Гарри Поттер", 650, sizeHarryPotter));
			var sizeGoneWithTheWind = new Size(180, 300);
			products.Add(new Book("Унесенные ветром", 350, sizeGoneWithTheWind));
			products.Add(new Vegetable("Картофель", TypeOfVegetable.Roots));
			products.Add(new Vegetable("Руккола", TypeOfVegetable.Leafy));
			return products;
		}
	}
}