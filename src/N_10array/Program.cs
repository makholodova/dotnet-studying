using System;

namespace N_10array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запись в матрицу результатов побитовых операций");


            int[,] array = new int[4, 8];

            Console.Write("Содержимое матрицы: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(0, 2);
                    array[i, j] = newNumber;
                }
            }


            for (int j = 0; j < 8; j++)
            {
                var num1 = array[0, j];
                var num2 = array[1, j];
                array[2, j] = num1 & num2;
                array[3, j] = num1 | num2 ;
            }


            for (int j = 0; j < 8; j++)
            {
                
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }
    }
}