using System;
using System.ComponentModel.DataAnnotations;

namespace N_7mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти наибольший элемент и его порядковый номер в массиве");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newHumber = rnd.Next(-1000, 1000);
                mass[i] = newHumber;
                Console.Write(mass[i] + " ");
            }

            var Max = int.MinValue;
            int Index = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] > Max)
                {
                    Max = mass[i];
                    Index = i;
                }
            }

            Console.WriteLine("\r\nНаибольший элемент: " + Max + " порядковый номер в массиве: " + Index);
        }
    }
}