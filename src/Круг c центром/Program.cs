using System;

namespace Круг_м_центром
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х ");
            string xStr = Console.ReadLine();
            double x = double.Parse(xStr);
            Console.WriteLine("Введите значение Y ");
            string yStr = Console.ReadLine();
            double y = double.Parse(yStr);
            Console.WriteLine("Введите значение радиуса R ");
            string rStr = Console.ReadLine();
            double r = double.Parse(rStr);
            double c;
            c = Math.Sqrt(x * x + y * y);
            Console.WriteLine("длина отрезка " + c);
            if (c <= r)
            {
                Console.WriteLine("Точка принадлежит кругу");
            }
            else Console.WriteLine("Точка не принадлежит кругу");

            Console.ReadLine();
        }
    }
}