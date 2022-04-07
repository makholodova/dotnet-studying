using System;

namespace N_27_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер минимального по модулю элемента массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            Console.Write("\r\nСодержимое массива: ");
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNum = rnd.Next(-10, 10);
                mass[i] = newNum;
                Console.Write(mass[i] + " ");
            }

            var min = int.MaxValue;
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                var num = Math.Abs(mass[i]);
                if (num < min)
                {
                    min = num;
                    index = i;
                }
            }

            Console.WriteLine("\r\nМинимальный по модулю элемент массива:" + min);
            Console.WriteLine("Номер минимального по модулю элемента массива:" + index);
        }
    }
}