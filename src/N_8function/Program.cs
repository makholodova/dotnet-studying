using System;

namespace N_8function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Переводить в двоичную систему счисления вводимые в десятичной системе
             счисления числа до тех пор, пока не будет введен 0. Для перевода 
             десятичного числа в двоичное написать функцию.*/

            Console.WriteLine("Функция перевода десятичного числа в двоичное");
            while (true)
            {
                Console.WriteLine("Введите число в десятичной системе");
                var numStr = Console.ReadLine();
                var num = int.Parse(numStr);
                if (num == 0)
                {
                    break;
                }

                var bin = ConversionToBinarySystem(num);
                Console.WriteLine("Число в двоичной системе: " + bin);
            }
        }

        static string ConversionToBinarySystem(int num)
        {
            var bin = "";

            while (num != 0)
            {
                var ostInt = num % 2;
                var ost = ostInt.ToString();
                bin = bin + ost;
                num = num / 2;
            }

            return bin;
        }
    }
}