using System;

namespace N_11array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить элементы матрицы по формуле A[i,j] = sin(N*(i+1)+M*(j+1))");
            var rndLine = new Random();
            var line = rndLine.Next(5, 6);
            var rndColumn = new Random();
            var column = rndColumn.Next(3, 5);

            double[,] array = new Double[line, column];

            Console.Write("Содержимое матрицы: ");

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    var variable = line * (i + 1) + column * (j + 1);
                    var num = Math.Sin(variable);
                    num = Math.Round(num, 2);
                    if (num < 0)
                    {
                        num = 0;
                    }

                    array[i, j] = num;
                    Console.Write(array[i, j] + " ");
                }
            }
        }
    }
}