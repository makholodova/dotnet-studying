namespace ClassOOP.N_16_Figure
{
	public class FigureEntryPoint : IEntryPoint
	{
		public void Start()
		{
			//var s = new Figure();
			var figures = new Figure[6];
			figures[0] = new Circle(8);
			figures[1] = new Rectangle(5,8);
			figures[2] = new Triangle(5, 7, 9);
			figures[3] = new Rectangle(9, 5);
			figures[4] = new Circle(4);
			figures[5] = new Triangle(12,5,9);
			foreach (var figure in figures)
			{
				figure.Print();
			}
		}
	}
}