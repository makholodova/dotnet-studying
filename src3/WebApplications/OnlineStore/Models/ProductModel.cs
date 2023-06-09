namespace OnlineStore.Models;

public class ProductModel
{
	public string Name { get; set; }
	public int Quantity { get; set; }
	public string Company { get; set; }
	public bool InStock { get; set; }
	public double Cost { get; set; }
	public Guid Id { get; set; }
}