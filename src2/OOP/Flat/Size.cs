namespace OOP.Flat
{
	public class Size
	{
		public double Wight { get; set; }
		public double Height { get; set; }
		public double Length { get; set; }

		public override string ToString()
		{
			return $"размер {Height}x{Length}x{Wight}";
		}
	}
}