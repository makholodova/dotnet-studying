namespace OnlineStore.Models;

public class OrderCreateModelPost
{
	public DateTime Time { get; set; }
	public Guid ProductId { get; set; }
	public Guid ClientId { get; set; }
}