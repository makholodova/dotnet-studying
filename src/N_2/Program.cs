using System;

namespace N_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            Console.WriteLine("Введите число");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            var countCh = 0;
            Console.Write("Сгенерированные числа: ");
            for (int i = 0; i < num; i++)
            {
                var newNumber = rnd.Next(0, 99);
                if (i < 100)
                {
                    Console.Write(" " + newNumber);
                }

                if (newNumber % 2 == 0)
                {
                    // если мы тут то число чётное
                    countCh++;
                }
            }

            Console.WriteLine("\r\nКолличество четных чисел " + countCh);
            var countNotCh = num - countCh;
            Console.WriteLine("Колличество нечетных чисел " + countNotCh);
            var pr = (countCh * 100) / (Decimal) num;
            Console.WriteLine($"Процент четных чисел {pr:F}");


            Console.ReadLine();
        }
    }
}