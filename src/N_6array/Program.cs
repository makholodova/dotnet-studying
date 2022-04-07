using System;

namespace N_6array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Максимальный элемент среди минимальных элементов столбцов матрицы");
            var rndLine = new Random();
            var line = rndLine.Next(5, 9);
            var rndColumn = new Random();
            var column = rndColumn.Next(5, 9);

            int[,] array = new int[line, column];

            Console.Write("Содержимое матрицы: ");

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(0, 999);
                    array[i, j] = newNumber;
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine("\r\nМинимум: ");

            var max = int.MinValue;
            for (int i = 0; i < column; i++)
            {
                var min = int.MaxValue;
                for (int j = 0; j < line; j++)
                {
                    var num = array[j, i];
                    if (num < min)
                    {
                        min = num;
                    }
                }

                Console.Write(min + " ");
                if (min > max)
                {
                    max = min;
                }
            }

            Console.WriteLine("\r\nМаксимальный элемент среди минимальных: " + max);
        }
    }
}