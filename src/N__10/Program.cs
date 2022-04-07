using System;

namespace N__10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать количество простых чисел");

            Console.WriteLine("Введите десять натуральных числел больше 2");

            int n = 0;
            for (int j = 0; j < 10; j++)
            {
                var numStr = Console.ReadLine();
                var num = int.Parse(numStr);
                int k = 0;

                for (int i = 2; i < num; i++)
                {
                    var fact = num % i;
                    if (fact == 0)
                    {
                        k++;
                    }
                }

                if (k == 0)
                {
                    n++;
                }
            }

            {
                Console.WriteLine("Kоличество простых чисел " + n);
            }
        }
    }
}