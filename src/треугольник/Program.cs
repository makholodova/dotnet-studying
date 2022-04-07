using System;

namespace треугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны треугольника");
            String oneStr = Console.ReadLine();
            decimal one = decimal.Parse(oneStr);
            Console.WriteLine("Введите длину второй стороны треугольника");
            String twoStr = Console.ReadLine();
            decimal two = decimal.Parse(twoStr);
            Console.WriteLine("Введите длину третьей стороны треугольника");
            String threeStr = Console.ReadLine();
            decimal three = decimal.Parse(threeStr);
            if (one + two <= three || one + three <= two || two + three <= one)
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }

            Console.WriteLine("Треугольник существует");
            if (one == two && two == three)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (one == two || two == three || one == three)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else Console.WriteLine("Треугольник разносторонний");

            Console.ReadLine();
        }
    }
}