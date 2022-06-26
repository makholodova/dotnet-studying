namespace ClassOOP.Bayer
{
	public class Size
	{
		public int Wight { get; private set; }
		public int Height { get; private set; }

		public Size(int wight, int height)
		{
			Wight = wight;
			Height = height;
		}
	}
}