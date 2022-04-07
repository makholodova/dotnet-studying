using System;

namespace N_1array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Положительные элементы главной диагонали!");
            var rndN = new Random();
            var n = rndN.Next(5, 7);
            int[,] array = new int[n, n]; //так как квадратная

            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    var rnd = new Random();
                    var newNumber = rnd.Next(-9, 9);
                    array[i, j] = newNumber;
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine("\r\nПоложительные элементы главной диагонали:");
            for (int i = 0; i < n; i++)
            {
                if (array[i,i]>0)
                {
                    
                    Console.Write(array[i, i] + " ");
                }
            }
        }
    }
}