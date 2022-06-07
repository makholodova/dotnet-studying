using ClassOOP.N_16_Figure;

namespace ClassOOP
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			IEntryPoint entryPoint;

			// entryPoint = new StudentEntryPoint();
			//entryPoint = new TrainEntryPoint();
			//entryPoint = new CalculatorEntryPoint();
			//entryPoint = new NameEntryPoint();
			//entryPoint = new MeterEntryPoint();
			entryPoint = new FigureEntryPoint();
			entryPoint.Start();
		}
	}
}