using System;

namespace N_22mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма и произведение элементов массива");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            decimal[] mass = new Decimal[n];
            Console.WriteLine("Введите вещественные числа");

            for (int i = 0; i < n; i++)
            {
                var newNumbStr = Console.ReadLine();
                var newNumb = decimal.Parse(newNumbStr);
                mass[i] = newNumb;
            }

            Console.Write("Содержимое массива: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }


            decimal sum = 0;
            decimal multi = 1;
            for (int i = 0; i < n; i++)
            {
                sum += mass[i];
                multi *= mass[i];
            }

            Console.WriteLine("\r\nСумма элементов массива: " + sum);
            Console.WriteLine("Сумма произведение массива: " + multi);
        }
    }
}