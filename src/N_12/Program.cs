using System;

namespace N_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            var sum = 0;
            var mult = 1;
            Console.WriteLine("Разбиваем на отдельные числа: ");
            while (num != 0)
            {
                int ost = num % 10;
                num = num / 10;

                Console.WriteLine(ost + ";");
                sum += ost;
                mult *= ost;
            }

            Console.WriteLine("Сумма чисел " + sum);
            Console.WriteLine("Произведение чисел " + mult);
            Console.ReadLine();
        }
    }
}