using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х");
            String xStr = Console.ReadLine();
            int x = int.Parse(xStr);
            Console.WriteLine("Введите значение Y");
            String yStr = Console.ReadLine();
            int y = int.Parse(yStr);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 1 четверти координатной четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во 2 четверти координатной четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 3 четверти координатной четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 4 четверти координатной четверти");
            }

            Console.ReadLine();
        }
    }
}