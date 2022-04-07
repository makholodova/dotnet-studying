using System;

namespace N_20mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество кратных чисел от 2 до 99 числам от 2 до 9");

            int[] mass = new int[8];
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 100; j++)
                {
                    int del = j % i;
                    if (del == 0)
                    {
                        mass[i - 2]++;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i+2 + " = " + mass[i]);
            }
        }
    }
}