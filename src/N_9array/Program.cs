using System;

namespace N_9array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка столбцов матрицы по возрастанию элементов первой строки");
            var rndLine = new Random();
            var line = rndLine.Next(5, 6);
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
                    var newNumber = rnd.Next(-9, 9);
                    array[i, j] = newNumber;
                    Console.Write(array[i, j] + " ");
                }
            }

            int min = 0;
            int indexMin = 0;
            for (int i = 0; i < column - 1; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < column; j++)
                {
                    if (array[0, j] < array[0, indexMin])
                    {
                        indexMin = j;
                    }
                }

                for (int j = 0; j < line; j++)
                {
                    min = array[j, indexMin];
                    array[j, indexMin] = array[j, i];
                    array[j, i] = min;
                }
            }


            Console.Write("\r\nМатрица после сортировки: ");
            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }
    }
}