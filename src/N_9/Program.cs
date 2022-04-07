using System;

namespace N_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ряд Фибоначчи!");
            Console.WriteLine("Введите колличество элементов ряда Фибонначчи");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int a = 1;
            int b = 0;
            int c;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                b = a;
                a = c;
                Console.WriteLine("Ряд Фибоначчи " + c);
            }

            Console.ReadLine();
        }
    }
}