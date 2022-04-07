using System;

namespace N_7funtion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дан одномерный массив, состоящий из натуральных чисел.
             Выполнить сортировку данного массива по возрастанию суммы цифр чисел.
              Например, дан массив чисел [14, 30, 103]. После сортировки он будет таким: [30, 103, 14], 
             так как сумма цифр числа 30 составляет 3, числа 103 равна 4, числа 14 равна 5.
              Вывести на экран исходный массив, отсортированный массив, а также для контроля 
             сумму цифр каждого числа отсортированного массива.*/

            Console.WriteLine("Отсортировать массив по возрастанию суммы цифр");

            var rnd = new Random();
            var n = rnd.Next(5, 9);
            int[] mass = new int[n];
            Console.Write("Содержимое исходного массива: ");
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(0, 200);
                Console.Write(mass[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    var num1 = mass[j];
                    int sum1 = SumOfDigits(num1);
                    var num2 = mass[j + 1];
                    int sum2 = SumOfDigits(num2);
                    if (sum1 > sum2)
                    {
                        mass[j] = num2;
                        mass[j + 1] = num1;
                    }
                }
            }

            Console.Write("\r\nСодержимое отсортированного массива: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }

            Console.Write("\r\nСумму цифр каждого числа отсортированного массива.: ");
            for (int i = 0; i < n; i++)
            {
                var num = mass[i];
                int sum = SumOfDigits(num);
                Console.Write(sum + " ");
            }
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                var ost = num % 10;
                sum += ost;
                num /= 10;
            }

            return sum;
        }
    }
}