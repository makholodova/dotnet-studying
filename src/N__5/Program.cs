using System;

namespace N__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод символов по диагонали");
            Console.WriteLine("Введите сторону треугольника");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);


            for (int i = 1; i < num; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < num; j++)
                {
                    int k = num - i;
                    if (j == i || j == k)
                    {
                        Console.Write("x");
                    }
                    else

                        Console.Write(" ");
                }
            }
        }
    }
}