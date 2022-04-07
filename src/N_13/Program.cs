using System;

namespace N_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            var CountCh = 0;
            var CountNotCh = 0;
            while (num != 0)
            {
                int ost = num % 10;
                num = num / 10;
                if (ost % 2 == 0)
                {
                    CountCh++;
                    Console.WriteLine(ost + " - четное число");
                }
                else
                {
                    CountNotCh++;
                    Console.WriteLine(ost + " - нечетное число");
                }
            }

            Console.WriteLine("Количество четных чисел:" + CountCh);
            Console.WriteLine("Количество нечетных чисел:" + CountNotCh);
            Console.ReadLine();
        }
    }
}