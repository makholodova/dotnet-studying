using System;

namespace N_4function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводит число. Сообщить, есть ли оно в массиве,
             элементы которого расположены по возрастанию значений, а также, 
             если есть, в каком месте находится. При решении задачи использовать 
             бинарный (двоичный) поиск, который оформить в виде отдельной функции.*/

            Console.WriteLine("Функция бинарного поиска в массиве");

            var mass = CreateAnArray();

            Console.WriteLine("\r\nВведите число");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);

            var ind = BinarySearch(mass, num);

            if (ind == -1)
            {
                Console.WriteLine("Такого числа нет");
            }
            else
            {
                Console.WriteLine("Находится на " + ind + " месте");
            }
        }

        private static int[] CreateAnArray()
        {
            var rnd = new Random();
            var n = rnd.Next(5, 9);
            int[] mass = new int[n];

            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(0, 30);
                Console.Write(mass[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    int n1 = mass[j];
                    int n2 = mass[j + 1];

                    if (n1 > n2)
                    {
                        mass[j] = n2;
                        mass[j + 1] = n1;
                    }
                }
            }

            Console.Write("\r\nСодержимое отсортированного массива: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }

            return mass;
        }

        static int BinarySearch(int[] mass, int num)
        {
            int ind = -1;
            var left = 0;
            var right = mass.Length;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (mass[mid] == num)
                {
                    ind = mid;
                    break;
                }

                if (mass[mid] < num)
                {
                    left = mid + 1;
                }

                if (mass[mid] > num)
                {
                    right = mid - 1;
                }
            }

            return ind;
        }
    }
}