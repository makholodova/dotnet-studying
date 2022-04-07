using System;

namespace N_15mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Элементы массива, которые меньше среднего арифметического");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 100);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
                sum += mass[i];
            }

            double ArithMean = (double) sum / n;

            Console.WriteLine("\r\nСреднеее арифметическое: " + ArithMean);
            Console.Write("Элементы массива, которые меньше среднего арифметического: ");
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < ArithMean)
                {
                    Console.Write(mass[i] + ", ");
                }
            }
        }
    }
}