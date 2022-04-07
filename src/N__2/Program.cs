using System;

namespace N__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти совершенные числа");


            for (int num = 0; num < 10000; num++)
            {
                int sum = 0;
                for (int j = 1; j < num; j++)

                {
                    if (num % j == 0)
                    {
                        sum += j;
                    }
                }


                if (num == sum)
                    Console.WriteLine("\r\nЧисло совершенно: " + num);
            }
        }
    }
}