using Microsoft.AspNetCore.Mvc;
using OnlineStore.DataBase;
using OnlineStore.Models;

namespace OnlineStore.Controllers;

public class ClientController : Controller
{
	// GET
	public IActionResult Index()
	{
		var clients = new List<ClientModel>();

		foreach (var client in OnlineStoreDb.Clients)
		{
			var clientModel = ConvertToClientModel(client);
			clients.Add(clientModel);
		}

		return this.View(clients);
	}

	private static ClientModel ConvertToClientModel(Client client)
	{
		var clientModel = new ClientModel
		{
			Name = client.Name, ContactPhone = client.ContactPhone, Address = client.Address, Id = client.Id
		};

		return clientModel;
	}

	[HttpGet]
	public IActionResult Create()
	{
		return this.View();
	}

	[HttpPost]
	public IActionResult Create(ClientModel client)
	{
		OnlineStoreDb.Clients.Add(new Client(client.Name, client.ContactPhone, client.Address, Guid.NewGuid()));
		return this.RedirectToAction("Index");
	}
}