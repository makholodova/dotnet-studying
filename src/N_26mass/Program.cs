using System;
using System.Diagnostics.CodeAnalysis;

namespace N_26mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Сумма модулей элементов массива, расположенных после первого отрицательного");
            var rndN = new Random();
            var n = rndN.Next(7, 10);
            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-9, 9);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            int indexNum = 0;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 0)
                {
                    indexNum = i;
                    break;
                }
            }

            for (int j = indexNum+1; j < n; j++)
            {
                mass[j] = Math.Abs(mass[j]);
                sum += mass[j];
            }


            Console.WriteLine("\r\nСумма модулей элементов массива, расположенных после первого отрицательного: " + sum);
        }
    }
}