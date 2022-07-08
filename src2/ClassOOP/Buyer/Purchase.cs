using System;
using System.Collections.Generic;

namespace ClassOOP.Buyer
{
	public class Purchase
	{
		public List<Product> Products { get; } = new List<Product>();

		public DateTime DateOfPurchase { get; private set; }

		public Purchase(Product product, DateTime dateOfPurchase)
		{
			Products = new List<Product> {product};
			DateOfPurchase = dateOfPurchase;
		}

		public Purchase(List<Product> products, DateTime dateOfPurchase)
		{
			Products = products;
			DateOfPurchase = dateOfPurchase;
		}

		public override string ToString()
		{
			var productsStr = string.Empty;
			foreach (var product in Products)
			{
				productsStr += $"{Environment.NewLine} {product.Name}, тип {product.GetType().Name}";
			}

			return $"Дата покупки: {DateOfPurchase}, {Environment.NewLine} Продукты: {productsStr}";
		}
	}
}