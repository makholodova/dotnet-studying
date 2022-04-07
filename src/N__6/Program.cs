using System;
using System.Diagnostics.CodeAnalysis;

namespace N__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти число с максимальной суммой чисел");
            Console.WriteLine("Введите числа ");

            int sum_max = 0;
            int num_max = 0;
            for (;;)
            {
                int sum = 0;
                var numStr = Console.ReadLine();
                var num = int.Parse(numStr);
                if (num != 0)
                {
                    int n = num;
                    while (n > 0)
                    {
                        int ost = n % 10;
                        n = n / 10;
                        sum += ost;
                    }


                    if (sum > sum_max)
                    {
                        sum_max = sum;
                        num_max = num;
                    }
                }
                else
                {
                    Console.WriteLine("Число " + num_max + " с максимальной суммой чисел равной " + sum_max);
                    return;
                }
            }
        }
    }
}