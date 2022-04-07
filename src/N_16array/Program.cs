using System;

namespace N_16array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Поменять столбцы матрицы местами");
            var rndLine = new Random();
            var line = rndLine.Next(5, 7);
            var rndColumn = new Random();
            var column = rndColumn.Next(4, 6);

            int[,] array = new int[line, column];

            Console.Write("Содержимое исходной матрицы: ");

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

            Console.WriteLine("\r\nВведите какие столбцы поменять местами");
            var column1Str = Console.ReadLine();
            var column1 = int.Parse(column1Str);
            var column2Str = Console.ReadLine();
            var column2 = int.Parse(column2Str);


            for (int j = 0; j < line; j++)
            {
                var num = array[j, column1];
                array[j, column1] = array[j, column2];
                array[j, column2] = num;
            }
            
            Console.Write("\r\nСодержимое измененной матрицы: ");
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