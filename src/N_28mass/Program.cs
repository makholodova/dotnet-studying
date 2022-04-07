using System;

namespace N_28mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма цифр массива");
            var rndN = new Random();
            var n = rndN.Next(5,7);
            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(1, 99);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }
            
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = mass[i];
                while (num != 0)
                {
                    int ost = num % 10;
                    num = num / 10;
                    sum += ost;
                } 
            }
            Console.WriteLine("\r\nСумма цифр массива: "+sum);
        }
    }
}