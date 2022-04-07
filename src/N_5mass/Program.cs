using System;

namespace N_5mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Максимальный отрицательный элемент массива");

            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] mass = new int[n];
            Console.Write("Содержимое массива: ");
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(-1000, 1000);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            var max = int.MinValue;
            int indx = 0;
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 0 && mass[i] > max)
                {
                    max = mass[i];
                    indx = i;
                }
            }


            Console.Write("\r\nМаксимальный отрицательный элемент: " + max + " позиция в массиве: " + indx);
        }
    }
}