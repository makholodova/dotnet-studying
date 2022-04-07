using System;

namespace N_3array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Суммы строк и столбцов матрицы");

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
                }
            }

            Console.WriteLine();

            var sumLine = 0;
            var sumColumn = 0;

            for (int i = 0; i < line; i++)
            {
                sumLine = 0;
                
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "  ");
                    sumLine += array[i, j];
                }

                Console.WriteLine(" " + sumLine);
            }
            Console.WriteLine();
            
            for (int i = 0; i < column; i++)
            {
                sumColumn = 0;
                for (int j = 0; j < line; j++)
                {
                   sumColumn += array[j, i];
                }

                Console.Write(sumColumn + " ");
            }
        }
    }
}