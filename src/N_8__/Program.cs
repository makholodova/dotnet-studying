using System;

namespace N_8__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            Console.Write("Число в обратном порядке: ");
            while (num != 0)
            {
                int ost = num % 10;
                num = num / 10;
                Console.Write(ost);
            }

            Console.ReadLine();
        }
    }
}