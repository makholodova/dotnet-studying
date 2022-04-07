using System;

namespace N_15array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Индексы минимальных элементов матрицы");
            var rndLine = new Random();
            var line = rndLine.Next(5, 7);
            var rndColumn = new Random();
            var column = rndColumn.Next(4, 6);

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

            var min = int.MaxValue;
            var indexMinLine = 0;
            var indexMinColumn = 0;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var num = array[i, j];
                    if (num < min)
                    {
                        min = num;
                        
                    }
                }
            }

            Console.WriteLine("\r\nМинимальное число " + min);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var num = array[i, j];
                    if (num == min)
                    {
                        indexMinLine = i;
                        indexMinColumn = j;
                        Console.WriteLine("Строка: " + indexMinLine + " Столбец: "+indexMinColumn);
                    }
                }
            }

           
        }
    }
}