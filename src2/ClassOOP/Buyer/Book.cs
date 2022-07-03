namespace ClassOOP.Buyer
{
	public class Book : Product
	{
		public int PageCount { get; private set; }
		public Size Size { get; private set; }

		public Book(string name, int pageCount, Size size) : base(name)
		{
			PageCount = pageCount;
			Size = size;
		}
	}
}