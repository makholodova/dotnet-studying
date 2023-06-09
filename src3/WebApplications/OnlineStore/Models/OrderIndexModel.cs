namespace OnlineStore.Models;

public class OrderIndexModel
{
	public string ClientName { get; set; }
	public string ContactPhone { get; set; }
	public string DeliveryAddress { get; set; }
	public DateTime Time { get; set; }
	public string ProductName { get; set; }
	public string ProductCompany { get; set; }
	public double ProductCost { get; set; }
	public Guid Id { get; set; }
}