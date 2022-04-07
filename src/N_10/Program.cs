using System;

namespace N_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите факториал");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Факториал = " + fact);
            Console.ReadLine();
        }
    }
}