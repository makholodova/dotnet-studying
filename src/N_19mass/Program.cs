using System;

namespace N_19mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка методом пузырька");
            var rndN = new Random();
            var n = rndN.Next(7, 9);

            int[] mass = new int[n];

            Console.Write("Содержимое исходного массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 10);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int n1 = mass[j];
                    int n2 = mass[j + 1];

                    if (n1 > n2)
                    {
                        mass[j] = n2;
                        mass[j + 1] = n1;
                    }
                }
            }

            Console.Write("\r\nСодержимое отсортированного массива: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}