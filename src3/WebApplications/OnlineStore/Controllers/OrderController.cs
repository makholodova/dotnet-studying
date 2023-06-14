using Microsoft.AspNetCore.Mvc;
using OnlineStore.DataBase;
using OnlineStore.Models;

namespace OnlineStore.Controllers;

public class OrderController : Controller
{
	// GET
	public IActionResult Index()
	{
		var orders = new List<OrderIndexModel>();
		foreach (var order in OnlineStoreDb.Orders)
		{
			var orderModel = ConvertToOrderModel(order);
			orders.Add(orderModel);
		}

		return this.View(orders);
	}

	private static OrderIndexModel ConvertToOrderModel(Order order)
	{
		var oderClient = OnlineStoreDb.Clients.First(client => client.Id == order.ClientId);
		var orderProduct = OnlineStoreDb.Products.First(product => product.Id == order.ProductId);
		var orderModel = new OrderIndexModel
		{
			ClientName = oderClient.Name,
			ContactPhone = oderClient.ContactPhone,
			DeliveryAddress = oderClient.Address,
			Time = order.Time,
			ProductName = orderProduct.Name,
			ProductCompany = orderProduct.Company,
			ProductCost = orderProduct.Cost,
			Id = order.Id
		};
		return orderModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		var oderModelGet = new OrderCreateModelGet();
		oderModelGet.Clients = OnlineStoreDb.Clients.Select(x => new ClientModel
			{ Id = x.Id, Address = x.Address, ContactPhone = x.ContactPhone, Name = x.Name }).ToList();
		oderModelGet.Products = OnlineStoreDb.Products.Select(x => new ProductModel
		{
			Name = x.Name,
			Company = x.Company,
			Cost = x.Cost,
			Id = x.Id,
			InStock = x.InStock,
			Quantity = x.Quantity
		}).ToList();
		return this.View(oderModelGet);
	}

	[HttpPost]
	public IActionResult Create(OrderCreateModelPost orderCreate)
	{
		OnlineStoreDb.Orders.Add(new Order(orderCreate.Time, orderCreate.ProductId, orderCreate.ClientId, Guid.NewGuid()));
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var order = OnlineStoreDb.Orders.First(x => x.Id == id);
		var clients = OnlineStoreDb.Clients.Select(x => new ClientModel
		{
			Name = x.Name,
			ContactPhone = x.ContactPhone,
			Address = x.Address,
			Id = x.Id
		}).ToList();
		var products = OnlineStoreDb.Products.Select(x => new ProductModel
		{
			Name = x.Name,
			Quantity = x.Quantity,
			Company = x.Company,
			InStock = x.InStock,
			Cost = x.Cost,
			Id = x.Id
		}).ToList();

		var orderUpdateModeGet = new OderUpdateModelGet
		{
			Products = products,
			Clients = clients,
			Time = order.Time,
			ProductId = order.ProductId,
			ClientId = order.ClientId,
			Id = order.Id
		};
		return this.View(orderUpdateModeGet);
	}

	[HttpPost]
	public IActionResult Update(OderUpdateModelPost order)
	{
		var orderDb = OnlineStoreDb.Orders.First(x => x.Id == order.Id);
		orderDb.ClientId = order.ClientId;
		orderDb.ProductId = order.ProductId;
		orderDb.Time = order.Time;
		return this.RedirectToAction("Index");
	}

	public IActionResult Delete(Guid id)
	{
		var client = OnlineStoreDb.Orders.RemoveAll(client => client.Id == id);
		return this.RedirectToAction("Index");
	}
}