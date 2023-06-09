namespace OnlineStore.Models;

public class OrderCreateModelGet
{
	public List<ProductModel> Products { get; set; }
	public List<ClientModel> Clients { get; set; }
}