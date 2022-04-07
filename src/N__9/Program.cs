using System;
using System.Net.Http.Json;

namespace N__9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения");

            int k = 0;

            for (int j = 1; j < 10; j++)
            {
                for (int i = 1; i < 10; i++)
                {
                    k = i * j;
                    Console.WriteLine(j + " x " + i + " = " + k);
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}