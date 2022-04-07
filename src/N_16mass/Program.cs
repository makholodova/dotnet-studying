using System;

namespace N_16mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вставка элемента в произвольное место массива");
            var rndN = new Random();
            var n = rndN.Next(5, 10);
            int[] mass = new int[n];

            Console.WriteLine("Содержимое массива: ");

            for (int i = 0; i < n - 1; i++)
            {
                var numStr = Console.ReadLine();
                var num = int.Parse(numStr);
                mass[i] = num;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }

            Console.WriteLine("\r\nУкажите еще одно значение и его позицию в массиве");
            var newNumStr = Console.ReadLine();
            var newNum = int.Parse(newNumStr);

            var newIndxStr = Console.ReadLine();
            var newIndx = int.Parse(newIndxStr);

            for (int i = n - 1; i > newIndx; i--)
            {
                mass[i] = mass[i - 1];
            }

            mass[newIndx] = newNum;
            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}