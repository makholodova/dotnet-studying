using System;

namespace N_25mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удаление отрицательных элементов массива");
            var rndN = new Random();
            var n = rndN.Next(5, 10);
            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");
            int i;
            for (i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-5, 7);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            Console.Write("Содержимое неотрицательного массива: ");
            var m = n;
            i = 0;
            while (i < m)
            {
                if (mass[i] < 0)
                {
                    m--;
                    for (int j = i; j < m; j++)
                    {
                        mass[j] = mass[j + 1];
                    }

                    mass[m] = 0;
                }

                else
                {
                    i++;
                }
            }


            /*for (int j = m; j < n; j++)
            {
                mass[j] = 0;
            }*/


            for (i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}