using System;

namespace N_17array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Записать матрицу в одномерный массив");
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
            Console.WriteLine("\r\nОдномерный массив:");
            var n = line * column;
            int[] mass = new int[n];
             int k = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                   mass[k]= array[j, i];
                   Console.Write(mass[k]+" ");
                   k++;
                }
            }
        }
    }
}