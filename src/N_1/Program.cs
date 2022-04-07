using System;

namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            var max = 0;
            while (n != 0)
            {
                int ost = n % 10;
                n = n / 10;
                Console.WriteLine("Разбиваем на отдельные числа " + ost);
                if (ost > max)
                {
                    max = ost;
                }
            }

            Console.WriteLine("Максимальное число " + max);

            Console.ReadLine();
        }
    }
}