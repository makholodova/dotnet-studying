using System;

namespace N_21mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество положительных, отрицательных и равных нулю элементов массива");
            Console.Write("Содержимое массива: ");
            int[] mass = new int[20];
            for (int i = 0; i < 20; i++)
            {
                var rnd = new Random();
                var newNum = rnd.Next(-5, 4);
                mass[i] = newNum;
                Console.Write(mass[i] + " ");
            }

            var positiveNumber = 0;
            var negаtiveNumber = 0;

            for (int i = 0; i < 20; i++)
            {
                var Number = mass[i];
                if (Number > 0)
                {
                    positiveNumber++;
                }
                else if (Number < 0)
                {
                    negаtiveNumber++;
                }
            }

            var zero = 20 - positiveNumber - negаtiveNumber;
            Console.WriteLine("\r\nКоличество положительных элементов массива: " + positiveNumber +
                              "\r\nКоличество отрицательных элементов массива: " + negаtiveNumber +
                              "\r\nКоличество равных нулю элементов массива: " + zero);
        }
    }
}