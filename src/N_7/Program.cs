using System;

namespace N_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество элементов");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            decimal sum = 0;
            decimal per = 1;
            for (var a = 0; a < n; a++)
            {
                sum += per;
                per /= 2;
            }

            Console.WriteLine("Сумма ряда = " + sum);
            Console.ReadLine();
        }
    }
}