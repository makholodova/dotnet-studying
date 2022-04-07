using System;

namespace N_6function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать функцию, которая определяет количество разрядов введенного целого числа.*/
            Console.WriteLine("Определить количество разрядов числа");
            Console.WriteLine("Введите число: ");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            var digit = NumberOfDigits(num);
            Console.WriteLine("Количество разрядов введенного числа: " + digit);
        }

        static int NumberOfDigits(int num)
        {
            var del = 0;
            while (num != 0)
            {
                num = num / 10;
                del++;
            }

            return del;
        }
    }
}