namespace OnlineStore.DataBase;

public static class OnlineStoreDb
{
	static OnlineStoreDb()
	{
		Merchandiser = "Roman";
		Products = new List<Product>();
		Products.Add(new Product(Guid.NewGuid(), "Яблоко", 15, "ГринФрукт", true, 50));
		Products.Add(new Product(Guid.NewGuid(), "Помидор", 50, "ГринФрукт", true, 40));
		Products.Add(new Product(Guid.NewGuid(), "Картошка", 50, "ГринФрукт", true, 15));
		Clients = new List<Client>();
		Clients.Add(new Client("Дмитрий", "89184710310", "Сарабеева 3", Guid.NewGuid()));
		Clients.Add(new Client("Ирина", "89184449260", "Чапаева 4", Guid.NewGuid()));
		Clients.Add(new Client("Ден", "89185874162", "Разведчиков 82", Guid.NewGuid()));
		Orders = new List<Order>();
	}

	public static string Merchandiser { get; }
	public static List<Product> Products { get; }
	public static List<Client> Clients { get; }
	public static List<Order> Orders { get; }
}