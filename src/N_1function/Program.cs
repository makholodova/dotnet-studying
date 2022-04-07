using System;
using System.Runtime.Intrinsics.Arm;

namespace N_1function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать функцию, которая заполняет массив случайными числами в диапазоне,
            указанном пользователем. Функция должна принимать два аргумента — начало диапазона
            и его конец, при этом ничего не возвращать. Вывод значений элементов массива должен
            происходить в основной ветке программы */

            Console.WriteLine("Функция заполнения массива случайными числами");
            Console.WriteLine("Введите диапозон чисел");
            var minStr = Console.ReadLine();
            var min = int.Parse(minStr);
            var maxStr = Console.ReadLine();
            var max = int.Parse(maxStr);
            
            int[] mass = new int[10];
            
            ArrayMassiv(mass, min, max);
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mass[i] + ", ");
            }
        }

        static void ArrayMassiv(int[] mass, int min, int max)
        {
            var rnd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                mass[i] = rnd.Next(min, max + 1);
            }
        }
    }
}