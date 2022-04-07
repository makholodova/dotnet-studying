using System;

namespace N_18mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка выбором ");

            var rndN = new Random();
            var n = rndN.Next(5, 7);

            int[] mass = new int[n];

            Console.Write("Содержимое массива: ");

            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNumber = rnd.Next(0, 10);
                mass[i] = newNumber;
                Console.Write(mass[i] + " ");
            }

            int min = 0;
            int minIndex = 0;
            for (int i = 0; i < n; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (mass[j] < mass[minIndex])
                    {
                        minIndex = j;
                    }
                }

                min = mass[minIndex]; // сохраняеи мин зн-ние
                mass[minIndex] = mass[i]; // сохраняем последний сравниваемый i элемент в позицию найденный мин
                mass[i] = min; // записываем мин зн-ние


            }


            Console.Write("\r\nМассив после сортировки: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}