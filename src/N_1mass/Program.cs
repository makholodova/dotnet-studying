using System;

// 1. Найти два наименьших (минимальных) элемента массива
// В одномерном массиве целых чисел определить два наименьших элемента.
// Они могут быть как равны между собой (оба являться минимальными), так и различаться.

namespace N_1mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти два наименьших элемента массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] nums = new int[n];
            Console.WriteLine("Введите значения элементов массива");
            for (int i = 0; i < n; i++)
            {
                var mStr = Console.ReadLine();
                var m = int.Parse(mStr);
                nums[i] = m;
            }

            int min2 = int.MaxValue;
            int min1 = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < min2)
                {
                    min1 = min2;
                    min2 = nums[i];
                }
            }

            Console.WriteLine("Два наименьших элемента массива: " + min1 + " и " + min2);

            Console.ReadLine();
        }
    }
}