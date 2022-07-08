using System;
using System.Collections.Generic;

namespace ClassOOP.Buyer
{
	public class Buyer
	{
		public string Name { get; }
		public List<Purchase> Purchases { get; } = new List<Purchase>();

		public Buyer(string name)
		{
			Name = name;
		}

		public void BayProduct(Product product)
		{
			var purchase = new Purchase(product, DateTime.Now);

			Purchases.Add(purchase);
		}

		public void BayProducts(List<Product> product)
		{
			var purchase = new Purchase(product, DateTime.Now);

			Purchases.Add(purchase);
		}
	}
}