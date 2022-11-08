namespace FirstWebApplication.Models;

public static class MobileContext
{
	static MobileContext()
	{
		Phones = new List<Phone>();
		Phones.Add(new Phone
		{
			Name = "iPhone X",
			Company = "Apple",
			Price = 600
		});
		Phones.Add(new Phone
		{
			Name = "Samsung Galaxy Edge",
			Company = "Samsung",
			Price = 550
		});
		Phones.Add(new Phone
		{
			Name = "Pixel 3",
			Company = "Google",
			Price = 500
		});
		Orders = new List<Order>();
	}

	public static List<Phone> Phones { get; private set; }
	public static List<Order> Orders { get; private set; }
}