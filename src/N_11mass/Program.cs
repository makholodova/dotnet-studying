using System;

namespace N_11mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реверс массива ");
            var rndN = new Random();
            var n = rndN.Next(5, 10);
            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-5, 7);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            Console.WriteLine("\r\nРеверс массива: ");
            var middle = n / 2;
            /*for (int i = middle; i < n; i++)
            {
                var num = mass[i];
                mass[i] = mass[(n - 1) - i];
                mass[(n - 1) - i] = num;
            }*/
            
            for (int i = 0; i < middle; i++)
            {
                var j = n - 1 - i;
                var num = mass[i];
                mass[i] = mass[j];
                mass[j] = num;
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}
