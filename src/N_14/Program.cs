using System;

namespace N_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            for (;;)

            {
                Console.WriteLine("Введите знак");
                var sign = Console.ReadLine();
                if (sign == "0")
                {
                    break;
                }

                else if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
                {
                    Console.WriteLine("Неверный знак, ведите занова");
                    continue;
                }

                Console.WriteLine("Введите число");
                var aStr = Console.ReadLine();
                var a = double.Parse(aStr);

                Console.WriteLine("Введите число");
                var bStr = Console.ReadLine();
                var b = double.Parse(bStr);
                double c = 0;
                if (sign == "+")
                {
                    c = a + b;
                }
                else if (sign == "-")
                {
                    c = a - b;
                }
                else if (sign == "*")
                {
                    c = a * b;
                }
                else if (sign == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Делить на '0' нельзя");
                        continue;
                    }

                    c = a / b;
                }

                Console.WriteLine("Результат = " + c);
            }
        }
    }
}