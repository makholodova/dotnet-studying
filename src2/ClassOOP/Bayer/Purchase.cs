using System;

namespace ClassOOP.Bayer
{
	public class Purchase
	{
		public Product[] Products { get; set; }

		public DateTime DateOfPurchase { get; private set; }

		public Purchase(Product product, DateTime dateOfPurchase)
		{
			Products = new[] {product};
			DateOfPurchase = dateOfPurchase;
		}

		public Purchase(Product[] products, DateTime dateOfPurchas)
		{
			Products = products;
			DateOfPurchase = dateOfPurchas;
		}

		public void CreatePurchase()
		{
		}
	}
}