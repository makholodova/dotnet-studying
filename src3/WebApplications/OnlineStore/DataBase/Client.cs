namespace OnlineStore.DataBase;

public class Client
{
	public Client(string name, string contactPhone, string address, Guid id)
	{
		this.Name = name;
		this.ContactPhone = contactPhone;
		this.Address = address;
		this.Id = id;
	}


	public string Name { get; set; }
	public string ContactPhone { get; set; }
	public string Address { get; set; }
	public Guid Id { get; }
}