using System;
using System.Diagnostics.CodeAnalysis;

namespace N_10mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Вывести неповторяющиеся элементы массива");
            var rndN = new Random();
            var n = rndN.Next(0, 10);
            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 5);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            Console.WriteLine("\r\nУникальные элементы массива: ");
            var num1 = 0;
            var num2 = 0;


            for (int i = 0; i < n; i++)
            {
                var s = true;
                num1 = mass[i];
                for (int j = 0; j < n; j++)
                {
                    num2 = mass[j];
                    if (num1 == num2 && i != j)
                    {
                        s = false;
                        break; //остановить цикл
                    }
                }

                if (s == true)
                {
                    Console.Write(num1 + " ");
                }
            }
        }
    }
}