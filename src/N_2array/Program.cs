using System;

namespace N_2array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти столбец матрицы с максимальной суммой элементов");

            var rndLine = new Random();
            var line = rndLine.Next(3, 5);
            var rndColumn = new Random();
            var column = rndColumn.Next(3, 5);

            int[,] array = new int[line, column];

            Console.Write("Содержимое матрицы: ");

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(0, 9);
                    array[i, j] = newNumber;
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine("\r\nСумма столбцов: ");
            var sum = 0;
            var sumMax = int.MinValue;
            for (int j = 0; j < column; j++)
            {
                sum = 0;
                for (int i = 0; i < line; i++)
                {
                    sum += array[i, j];
                }

                if (sum > sumMax)
                {
                    sumMax = sum;
                }

                Console.Write(sum + " ");
            }

            Console.WriteLine("\r\nСтолбец матрицы с максимальной суммой элементов: " + sumMax);
        }
    }
}