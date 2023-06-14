namespace OnlineStore.Models;

public class OderUpdateModelPost
{
	public DateTime Time { get; set; }
	public Guid ProductId { get; set; }
	public Guid ClientId { get; set; }
	public Guid Id { get; set; }
}