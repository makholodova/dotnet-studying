using System;

namespace N_4array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество двузначных чисел в матрице");

            var rndLine = new Random();
            var line = rndLine.Next(5, 7);
            var rndColumn = new Random();
            var column = rndColumn.Next(5, 7);

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

            var number = 0;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var num = array[i, j];
                    if (num >= 10 && num <= 99)
                    {
                        number++;
                    }
                }
            }

            Console.WriteLine("Количество двузначных чисел в матрице: " + number);
        }
    }
}