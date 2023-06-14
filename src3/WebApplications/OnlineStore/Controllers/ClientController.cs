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

	[HttpGet]
	public IActionResult Update(Guid id)
	{
		var client = OnlineStoreDb.Clients.First(client => client.Id == id);
		var clientModel = ConvertToClientModel(client);
		return this.View(clientModel);
	}

	[HttpPost]
	public IActionResult Update(ClientModel client)
	{
		var clientDb = OnlineStoreDb.Clients.First(clientDb => clientDb.Id == client.Id);
		clientDb.Name = client.Name;
		clientDb.ContactPhone = client.ContactPhone;
		clientDb.Address = client.Address;
		return this.RedirectToAction("Index");
	}

	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		OnlineStoreDb.Clients.RemoveAll(x => x.Id == id);
		return this.RedirectToAction("Index");
	}
}