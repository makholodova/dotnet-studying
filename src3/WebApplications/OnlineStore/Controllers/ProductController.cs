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

	public IActionResult Delete(Guid id)
	{
		OnlineStoreDb.Products.RemoveAll(x => x.Id == id);
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var product = OnlineStoreDb.Products.First(x => x.Id == id);
		var productModel = ConvertToProductModel(product);
		return this.View(productModel);
	}

	[HttpPost]
	public IActionResult Update(ProductModel product)
	{
		var productDb = OnlineStoreDb.Products.First(x => x.Id == product.Id);
		productDb.Company = product.Company;
		productDb.InStock = product.InStock;
		productDb.Cost = product.Cost;
		productDb.Quantity = product.Quantity;
		productDb.Name = product.Name;
		return this.RedirectToAction("Index");
	}
}