using System;

namespace N_8array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обмен значений главной и побочной диагоналей квадратной матрицы");
            var rndLine = new Random();
            var line = rndLine.Next(10, 10);
            var rndColumn = new Random();
            var column = rndColumn.Next(10, 10);

            int[,] array = new int[line, column];

            Console.Write("Содержимое матрицы: ");

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(10, 99);
                    array[i, j] = newNumber;
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.Write("\r\nСодержимое новой матрицы: ");

            for (int i = 0; i < line; i++)
            {
                var num = array[i, i];
                var lastIndex = line - 1 - i;
                array[i, i] = array[i, lastIndex];
                array[i, lastIndex] = num;

                Console.WriteLine();
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