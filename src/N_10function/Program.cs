using System;

namespace N_10function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В зависимости от выбора пользователя вычислить площадь круга, прямоугольника или треугольника.
             Для вычисления площади каждой фигуры должна быть написана отдельная функция.*/

            Console.WriteLine("Найти площади разных фигур");
            Console.WriteLine("Выбирите фигуру:круг(0), прямоугольника(4) или треугольника(3) ");
            var formStr = Console.ReadLine();
            var form = int.Parse(formStr);
            double s = 0;
            if (form == 0)
            {
                Console.WriteLine("Введите длину радиуса");
                var rStr = Console.ReadLine();
                var r = int.Parse(rStr);
                s = FindTheAreaOfCircle(r);
            }
            else if (form == 4)
            {
                Console.WriteLine("Введите длину стороны a");
                var aStr = Console.ReadLine();
                var a = int.Parse(aStr);
                Console.WriteLine("Введите длину стороны b");
                var bStr = Console.ReadLine();
                var b = int.Parse(bStr);
                s = FindTheAreaOfRectangle(a, b);
            }
            else if (form == 3)
            {
                Console.WriteLine("Введите длину стороны a");
                var aStr = Console.ReadLine();
                var a = double.Parse(aStr);
                Console.WriteLine("Введите длину стороны b");
                var bStr = Console.ReadLine();
                var b = int.Parse(bStr);
                Console.WriteLine("Введите длину стороны c");
                var cStr = Console.ReadLine();
                var c = int.Parse(cStr);
                s = FindTheAreaOfTrigon(a, b, c);
            }

            Console.WriteLine("Площадь: " + s);
        }

        static double FindTheAreaOfCircle(int r)
        {
            //var s =Math.PI * Math.Pow(r, 2);
            return Math.PI * Math.Pow(r, 2);
        }

        static int FindTheAreaOfRectangle(int a, int b)
        {
            //var s =a * b ;
            return a * b;
        }

        static double FindTheAreaOfTrigon(double a, int b, int c)
        {
            var p = (a + b + c) / 2;
            //var s = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}