using System;

namespace f_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить значение функции f(X)!");
            Console.WriteLine("Введите значение х");
            string xStr = Console.ReadLine();
            decimal x = decimal.Parse(xStr);
            decimal y;
            if (x > 0)
            {
                y = 2 * x - 10;
                Console.WriteLine("y = " + y);
            }
            else if (x == 0)
            {
                y = 0;
                Console.WriteLine("y = " + y);
            }
            else
            {
                y = 2 * Math.Abs(x) - 1;
                Console.WriteLine("y = " + y);
            }

            Console.ReadLine();
        }
    }
}