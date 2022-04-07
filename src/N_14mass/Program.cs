using System;

namespace N_14mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Максимальный из элементов массива с четными индексами");

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

            var index = 0;
            var max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                    continue;

                if (mass[i] > max)
                {
                    max = mass[i];
                    index = i;
                }
            }

            Console.WriteLine("\r\nМаксимальный из элементов массива с четными индексами: " + max + "\r\nИндекс: " +
                              index);
        }
    }
}