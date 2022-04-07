using System;

namespace N__1v2
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
            int i;

            for (int j = 0; j <= sh; j++)
            {
                Console.WriteLine();
                for (i = 0; i <= dl; i++)
                {
                    if (j == 0 || j == sh)
                    {
                        Console.Write("o");
                    }
                    else if (i == 0 || i == dl)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write("w");
                    }
                }
            }
        }
    }
}