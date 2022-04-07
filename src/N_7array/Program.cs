using System;

namespace N_7array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполнение третьей матрицы по результатам сравнения элементов первых двух");
            var rndLine = new Random();
            var line = rndLine.Next(4, 5);
            var rndColumn = new Random();
            var column = rndColumn.Next(5, 7);

            int[,] array1 = new int[line, column];
            int[,] array2 = new int[line, column];
            int[,] array3 = new int[line, column];

            Console.Write("Содержимое матрицы #1: ");

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(0, 20);
                    array1[i, j] = newNumber;
                    Console.Write(array1[i, j] + "  ");
                }
            }
            Console.Write("\r\nСодержимое матрицы #2: ");

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(0, 20);
                    array2[i, j] = newNumber;
                    Console.Write(array2[i, j] + "  ");
                }
            }
            Console.Write("\r\nСодержимое матрицы #3: ");
            
            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    if(array1[i,j]>=array2[i,j])
                    {
                        array3[i, j] = array1[i,j];
                    }
                    else
                    {
                        array3[i, j] = array2[i,j];
                    }
                    Console.Write(array3[i, j] + "  ");
                }
            }
            
        }
    }
}