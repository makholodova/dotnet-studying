using System;

namespace N_12function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать функцию, которая вычисляет среднее арифметическое элементов массива,
             переданного ей в качестве аргумента.*/

            Console.WriteLine("Функция, вычисляющая среднее арифметическое элементов массива");
            var rnd = new Random();
            var n = rnd.Next(5, 9);
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(0, 10);
                Console.Write(mass[i] + " ");
            }

            var mean = ArithmeticMeanOfArrayElements(mass);

            Console.WriteLine("\r\nСреднее арифметическое элементов массива: "+mean.ToString("F"));
        }

        static decimal ArithmeticMeanOfArrayElements(int[] mass)
        {
            decimal sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }
            
            return sum/mass.Length;
        }
    }
}