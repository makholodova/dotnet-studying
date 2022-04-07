using System;

namespace N_8masss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять местами минимальный и максимальный элементы");

            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 100);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            var max = int.MinValue;
            var iMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                    iMax = i;
                }
            }

            Console.WriteLine("\r\nМаксимальное значение: " + max + " Индекс: " + iMax);
            var min = int.MaxValue;
            var iMin = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                    iMin = i;
                }
            }

            Console.WriteLine("Минимальное значение: " + min + " Индекс: " + iMin);
            Console.Write("Измененный массив: ");
            mass[iMin] = max;
            mass[iMax] = min;
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}