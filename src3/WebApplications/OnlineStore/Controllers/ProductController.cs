using Microsoft.AspNetCore.Mvc;
using OnlineStore.DataBase;
using OnlineStore.Models;

namespace OnlineStore.Controllers;

public class ProductController : Controller
{
	// GET
	public IActionResult Index()
	{
		var products = new List<ProductModel>();
		foreach (var product in OnlineStoreDb.Products)
		{
			var productModel = ConvertToProductModel(product);
			products.Add(productModel);
		}

		return this.View(products);
	}

	private static ProductModel ConvertToProductModel(Product product)
	{
		var productModel = new ProductModel
		{
			Name = product.Name,
			Quantity = product.Quantity,
			Company = product.Company,
			InStock = product.InStock,
			Cost = product.Cost,
			Id = product.Id
		};
		return productModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(ProductModel product)
	{
		OnlineStoreDb.Products.Add(new Product(Guid.NewGuid(), product.Name, product.Quantity, product.Company, product.InStock, product.Cost));
		return this.RedirectToAction("Index");
	}
}