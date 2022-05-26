using ClassOOP.N_2_Train;
using ClassOOP.N_3;
using ClassOOP.N_5_Constructor;

namespace ClassOOP
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			IEntryPoint entryPoint;

			// entryPoint = new StudentEntryPoint();
			//entryPoint = new TrainEntryPoint();
			entryPoint = new CalculatorEntryPoint();
			//entryPoint = new NameEntryPoint();
			entryPoint.Start();
		}
	}
}