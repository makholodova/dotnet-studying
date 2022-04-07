using System;

namespace N_4mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Среднее арифметическое положительных элементов массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-100, 100);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            var sum = 0;
            double m = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] > 0)
                {
                    sum += mass[i];
                    m++;
                }
            }

            double srd = sum / m; //double srd = sum / (double) m;
            Console.WriteLine("\r\nСреднее арифметическое положительных элементов массива = " + srd);
        }
    }
}