using System;

namespace N_29mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти сумму элементов между минимальным и максимальным элементами массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            Console.Write("\r\nСодержимое массива: ");
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNum = rnd.Next(0, 20);
                mass[i] = newNum;
                Console.Write(mass[i] + " ");
            }

            var min = int.MaxValue;
            var max = int.MinValue;

            var indexMin = 0;
            var indexMax = 0;

            for (int i = 0; i < n; i++)
            {
                var num = mass[i];
                if (num < min)
                {
                    min = num;
                    indexMin = i;
                }
                else if (num > max)
                {
                    max = num;
                    indexMax = i;
                }
            }

            Console.WriteLine("\r\nМинимальный элемент массива: " + min + "  Индекс: " + indexMin +
                              " \r\nMаксимальный элемент массива: " + max + "  Индекс: " + indexMax);
            var sum = 0;
            if (indexMin < indexMax)
            {
                for (int i = indexMin + 1; i < indexMax; i++)
                {
                    sum += mass[i];
                }
            }
            else if (indexMax < indexMin)
            {
                for (int i = indexMax + 1; i < indexMin; i++)
                {
                    sum += mass[i];
                }
            }


            Console.WriteLine("Сумма элементов между минимальным и максимальным элементами массива: " + sum);
        }
    }
}