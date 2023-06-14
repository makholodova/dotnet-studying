namespace OnlineStore.Models;

public class OderUpdateModelGet
{
	public List<ProductModel> Products { get; set; }
	public List<ClientModel> Clients { get; set; }
	public DateTime Time { get; set; }
	public Guid ProductId { get; set; }
	public Guid ClientId { get; set; }
	public Guid Id { get; set; }
}