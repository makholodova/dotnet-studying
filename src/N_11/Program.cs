using System;

namespace N_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное значение");
            var maxStr = Console.ReadLine();
            var max = int.Parse(maxStr);

            Console.WriteLine("Введите минимальное значение");
            var minStr = Console.ReadLine();
            var min = int.Parse(minStr);

            Console.WriteLine("Введите шаг");
            var shStr = Console.ReadLine();
            var sh = int.Parse(shStr);

            Console.Write("Ряд натуральных чисел: ");
            for (int n = min; n <= max; n += sh)
            {
                Console.Write(" " + n);
            }

            Console.ReadLine();
        }
    }
}