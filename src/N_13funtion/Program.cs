using System;

namespace N_13funtion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сгенерировать десять массивов из случайных чисел. 
                    Вывести их и сумму их элементов на экран. 
                    Найти среди них один с максимальной суммой элементов.
                    Указать какой он по счету, повторно вывести этот массив и сумму его элементов.
                    Заполнение массива и подсчет суммы его элементов оформить в виде отдельной функции.*/

            Console.WriteLine("Найти массив с максимальной суммой элементов");
            var rnd = new Random();
            var n = rnd.Next(5, 8);
            int[] massMax = new int[n];
            var sumMax = int.MinValue;
            var num = 0;
            for (int i = 0; i < 10; i++)
            {
                var mass = new int[n];

                var sum = FillingAnArrayAndCountingTheSum(mass);
                Console.WriteLine();
                if (sum > sumMax)
                {
                    sumMax = sum;
                    num = i + 1;
                    massMax = mass;
                    /*for (int j = 0; j < n; j++)
                    {
                        massMax[j] = mass[j];
                    }*/
                }
            }

            Console.WriteLine(num + " по счету" + " массив с максимальной суммой элементов:");
            for (int j = 0; j < n; j++)
            {
                Console.Write(massMax[j] + " ");
            }

            Console.Write("= " + sumMax);
        }

        static int FillingAnArrayAndCountingTheSum(int[] mass)
        {
            int sum = 0;
            var rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
                Console.Write(mass[i] + " ");
                sum += mass[i];
            }

            Console.Write("= " + sum);
            return sum;
        }
    }
}