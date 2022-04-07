using System;

namespace N_2function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вычислить значения нижеприведенной функции в диапазоне значений x от -10 до 10 включительно
             с шагом, равным 1.
             y = x2 при -5 <= x <= 5;
             y = 2*|x|-1 при x < -5;
             y = 2x при x > 5.
             Вычисление значения функции оформить в виде программной функции, которая принимает значение x,
              а возвращает полученное значение функции (y).*/
            Console.WriteLine("Вычислить значения функции y=f(x) на заданном диапазоне");

            for (int x = -10; x <= 10; x++)
            {
                var y = CalculateFunctionValue(x);
                Console.Write(y + ", ");
            }
        }

        static int CalculateFunctionValue(int x)
        {
            var y = 0;
            if (x < -5)
            {
                x = Math.Abs(x);
                y = 2 * x - 1;
            }
            else if (x > 5)
            {
                y = 2 * x;
            }
            else
            {
                y = x * x;
            }

            return y;
        }
    }
}