using System;

namespace N_5function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Вычислить сумму ряда
                 5
             s = ∑ (-1) * i * (x / i!)
                i=1                    
             Значение x вводится с клавиатуры. */

            Console.WriteLine("Сумма ряда с факториалом");
            Console.WriteLine("Введите значение х ");
            var xStr = Console.ReadLine();
            var x = int.Parse(xStr);
            double sum = CalculateTheSum(x);
            Console.WriteLine("Вычислить сумму ряда: " + sum);
        }

        static double CalculateTheSum(int x)
        {
            double sum = 0;
            for (var i = 1; i <= 5; i++)
            {
                var fact = 1;
                for (var j = 1; j <= i; j++)
                {
                    fact *= j;
                }

                sum += -1 * i * ((double)x / fact);
            }

            return sum;
        }
    }
}