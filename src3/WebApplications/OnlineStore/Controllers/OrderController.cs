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
			{ Company = x.Company, Cost = x.Cost, InStock = x.InStock, Quantity = x.Quantity }).ToList();
		return this.View(oderModelGet);
	}

	[HttpPost]
	public IActionResult Create(OrderCreateModelPost orderCreate)
	{
		OnlineStoreDb.Orders.Add(new Order(orderCreate.Time, orderCreate.ProductId, orderCreate.ClientId, Guid.NewGuid()));
		return this.RedirectToAction("Index");
	}
}