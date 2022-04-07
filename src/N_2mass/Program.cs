using System;
using System.Reflection.Metadata;

namespace N_2mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определить индексы четных элементов массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int[] nums1 = new int[n];
            Console.Write("Содержимое массива nums1: ");
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 10000);
                nums1[i] = newNumber;
                Console.Write(nums1[i] + " ");
            }


            int[] nums2 = new int[n]; //кол-во элементов 2-го массива не будет превышать, кол-во в 1-ом
            // Console.WriteLine();

            Console.Write("\r\nСодержимое массива nums2: ");
            var ii = 0;
            for (int i = 0; i < n; i++)
            {
                var k = nums1[i] % 2;
                if (k == 0)
                {
                    nums2[ii] = i;
                    ii++;
                    Console.Write(nums2[i] + " ");
                }
            }

            for (int i = 0; i < ii; i++)
            {
                Console.Write(nums2[i] + " ");
            }
        }
    }
}