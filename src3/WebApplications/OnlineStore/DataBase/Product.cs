namespace OnlineStore.DataBase;

public class Product
{
	public Product(Guid id, string name, int quantity, string company, bool inStock,double cost)
	{
		this.Id = id;
		this.Name = name;
		this.Quantity = quantity;
		this.Company = company;
		this.InStock = inStock;
		this.Cost = cost;
	}

	
	public Guid Id { get; }
	public string Name { get; set; }
	public int Quantity { get; set; }
	public string Company { get; set; }
	public bool InStock { get; set; }
	public double Cost { get; set; }
}