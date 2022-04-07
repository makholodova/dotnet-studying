using System;

namespace N_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица значений функции  y = -0.23x2 + x");
            Console.WriteLine("Введите min значение x");
            var minStr = Console.ReadLine();
            var min = double.Parse(minStr);
            Console.WriteLine("Введите max значение x");
            var maxStr = Console.ReadLine();
            var max = double.Parse(maxStr);
            Console.WriteLine("Введите шаг");
            var incStr = Console.ReadLine();
            var inc = double.Parse(incStr);
            double y;
            for (var i = min; i <= max; i += inc)
            {
                Console.WriteLine("Значение х = " + i);
                y = -0.23 * i * i + i;
                Console.WriteLine("Значение y = " + y);
            }
        }
    }
}