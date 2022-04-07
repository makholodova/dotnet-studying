using System;

namespace N_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            Console.Write("Число в обратном порядке: ");
            do
            {
                int ost = num % 10;
                num = num / 10;
                Console.Write(ost);
            } while (num > 0);

            Console.ReadLine();
        }
    }
}