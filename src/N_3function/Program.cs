using System;
using System.IO;

namespace N_3function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Найти наибольшие общие делители (НОД) для множества пар чисел.*/
            Console.WriteLine("Вычисление наибольших общих делителей");

            int num1, num2;
            do
            {
                Console.WriteLine("Введите 2 числа");
                var num1Str = Console.ReadLine();
                num1 = int.Parse(num1Str);
                var num2Str = Console.ReadLine();
                num2 = int.Parse(num2Str);
                var denominator = СalculationDenominator(num1, num2);
                Console.WriteLine("НОД: " + denominator);
            } while (num1 != 0 && num2 != 0);
        }

        static int СalculationDenominator(int num1, int num2)
        {
            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 = num1 % num2;
                }
                else
                {
                    num2 = num2 % num1;
                }
            }

            return num1 + num2;
        }
    }
}