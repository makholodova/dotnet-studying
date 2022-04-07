using System;

namespace N_13mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти максимальный по модулю элемент в массиве с уникальными по модулю значениями");
            var rndN = new Random();
            var n = rndN.Next(0, 10);

            Console.Write("\r\nСгенирированные числа: ");
            int[] mass = new int[n];

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNum = rnd.Next(-10, 11);
                mass[i] = newNum;
                Console.Write(mass[i] + " ");
            }

            int[] massUni = new int[n];
            var indxUni = 0;

            for (int i = 0; i < n; i++)
            {
                var num1 = Math.Abs(mass[i]);
                var sum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    var num2 = Math.Abs(mass[j]);
                    if (num1 == num2)
                    {
                        sum++;
                    }
                }

                if (sum == 0)
                {
                    massUni[indxUni] = mass[i];
                    indxUni++;
                }
            }

            Console.Write("\r\nСодержимое массива: ");
            for (int i = 0; i < indxUni; i++)
            {
                Console.Write(massUni[i] + " ");
            }

            var maxNumber = int.MinValue;
            for (int i = 0; i < indxUni; i++)
            {
                var number = Math.Abs(massUni[i]);
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine("\r\nНаибольшее по модулю число: " + maxNumber);
        }
    }
}