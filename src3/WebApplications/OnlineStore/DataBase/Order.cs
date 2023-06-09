namespace OnlineStore.DataBase;

public class Order
{
	public Order( DateTime time, Guid productId, Guid clientId, Guid id)
	{
		this.Time = time;
		this.ProductId = productId;
		this.ClientId = clientId;
		this.Id = id;
	}

	public DateTime Time { get; set; }
	public Guid ProductId { get; set; }
	public Guid ClientId { get; set; }
	public Guid Id { get; }
}