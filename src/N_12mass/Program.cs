using System;

namespace N_12mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Сумма четных положительных элементов массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-10, 10);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var numb = mass[i];
                var del = mass[i] % 2;
                if (numb > 0 && del == 0)
                {
                    sum += mass[i];
                }
            }

            Console.WriteLine("\r\nСумма четных положительных элементов массива: " + sum);
        }
    }
}