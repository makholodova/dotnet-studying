using System;
using System.Runtime.InteropServices.ComTypes;

namespace N__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доказательство гипотезы Сиракуз");
            Console.WriteLine("Введите начальное число");
            var num1Str = Console.ReadLine();
            var num1 = int.Parse(num1Str);
            Console.WriteLine("Введите последнее число");
            var num2Str = Console.ReadLine();
            var num2 = int.Parse(num2Str);

            for (int i = num1; i <= num2; i++)
            {
                var k = i;
                Console.WriteLine("\r\nЧисло " + k + ":");
                while (k != 1)
                {
                    if (k % 2 == 0)
                    {
                        k = k / 2;
                    }

                    else
                    {
                        k = (k * 3 + 1) / 2;

                        //Console.WriteLine("Нечетное " + k);
                    }

                    Console.Write(k + ", ");
                }
            }
        }
    }
}