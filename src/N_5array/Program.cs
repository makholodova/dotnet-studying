using System;

namespace N_5array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Последний элемент строк матрицы = сумма предыдущих элементов строки");

            var rndLine = new Random();
            var line = rndLine.Next(5, 5);
            var rndColumn = new Random();
            var column = rndColumn.Next(4, 4);

            int[,] array = new int[line, column];

            Console.Write("Содержимое матрицы: ");
            var sum = 0;
            for (int i = 0; i < line; i++)
            {
                sum = 0;
                for (int j = 0; j < column - 1; j++)  //здесь -1, так как нужен предпоследний элемент
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(0, 9);
                    array[i, j] = newNumber;
                    sum += array[i, j];
                }

                array[i, column-1] = sum; //здесь -1, так как индексация с 0
            }

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