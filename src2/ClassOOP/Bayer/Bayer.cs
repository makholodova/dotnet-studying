using System;
using System.Collections.Generic;

namespace ClassOOP.Bayer
{
	public class Bayer
	{
		public string Name { get; set; }
		public List<Purchase> Purchases { get; } = new List<Purchase>();

		public void Bay(Product product)
		{
			var purchase = new Purchase(product, DateTime.Now);

			Purchases.Add(purchase);
		}
	}
}