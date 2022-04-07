using System;
using System.Net.Http.Json;

namespace N_9function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана квадратная матрица. Вычислить сумму элементов главной или побочной
             диагонали в зависимости от выбора пользователя. Сумма элементов любой диагонали 
             должна вычисляться в одной и той же функции.*/

            Console.WriteLine("Вычислить сумму элементов главной или побочной диагонали матрицы");

            var rnd = new Random();
            var n = rnd.Next(3, 6);
            int[,] mass = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    var num = rnd.Next(0, 10);
                    mass[i, j] = num;
                    Console.Write(mass[i, j] + " ");
                }
            }

            Console.WriteLine("\r\nВведите диагональ main (M) или lateral(L)");
            var side = Console.ReadLine();

            var sum = TheSumOfTheDiagonal(side, mass, n);
            Console.WriteLine("Сумма элементов диагонали матрицы = " + sum);
        }

        static int TheSumOfTheDiagonal(string side, int[,] mass, int n)
        {
            var sum = 0;
            if (side == "M")
            {
                for (int i = 0; i < n; i++)
                {
                    sum += mass[i, i];
                }
            }

            else if (side == "L")
            {
                int j = n - 1;
                for (int i = 0; i < n; i++)
                {
                    sum += mass[i, j];
                    j--;
                }
            }

            return sum;
        }
    }
}