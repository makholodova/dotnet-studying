using System;

namespace N_3mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов массива больше по модулю максимального");
            int[] mass = new int[20];

            Console.Write("Содержимое массива: ");
            for (int i = 0; i < 20; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-15, 15);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            int max = mass[0];
            for (int i = 0; i < 20; i++)
            {
                max = Math.Max(max, mass[i]);
            }

            Console.WriteLine("\r\nМаксимальный элемент массива: " + max);
            int n = 0;
            for (int i = 0; i < 20; i++)
            {
                int k = Math.Abs(mass[i]);
                if (k > max)
                {
                    n++;
                }
            }

            Console.WriteLine("Сколько элементов массива больше по модулю максимального: " + n);
        }
    }
}