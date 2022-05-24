using ClassOOP.N_2_Train;
using ClassOOP.N_3;
using ClassOOP.N_5_Constructor;
using ClassOOP.Student;

namespace ClassOOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IEntryPoint entryPoint;

           // entryPoint = new StudentEntryPoint();
          //entryPoint = new TrainEntryPoint();
         //entryPoint = new NumEntryPoint();
         entryPoint = new NameEntryPoint();
            entryPoint.Start();
        }
    }
}