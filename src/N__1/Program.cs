using System;

namespace N__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прямоугольник из символов");
            Console.WriteLine("Введите длину прямоугольника");
            var dlStr = Console.ReadLine();
            var dl = int.Parse(dlStr);
            Console.WriteLine("Введите ширину прямоугольника");
            var shStr = Console.ReadLine();
            var sh = int.Parse(shStr);
            for (int i = 0; i <= dl + 1; i++)
            {
                Console.Write("o");
            }

            Console.WriteLine();
            for (int i = 0; i < sh; i++)
            {
                Console.Write("o");
                for (int j = 0; j <= (dl - 1); j++)
                {
                    Console.Write("w");
                }

                Console.WriteLine("o");
            }

            for (int i = 0; i <= dl + 1; i++)
            {
                Console.Write("o");
            }
        }
    }
}