namespace ClassOOP.Bayer
{
	public abstract class Product
	{
		public string Name { get; private set; }

		public Product(string name)
		{
			Name = name;
		}
	}
}