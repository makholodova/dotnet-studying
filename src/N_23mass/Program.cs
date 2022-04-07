using System;

namespace N_23mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполнение и вывод массивов");
            Console.WriteLine("Введите кол-во элементов массива");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            Console.WriteLine("Введите значения массива №1: ");
            int[] mass1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                var newNum1Str = Console.ReadLine();
                var newNum1 = int.Parse(newNum1Str);
                mass1[i] = newNum1;
            }

            Console.Write("Содержимое массива №1: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass1[i] + " ");
            }


            Console.Write("\r\nСодержимое массива №2: ");
            int[] mass2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                var newNum2 = rnd.Next(0, 10);
                mass2[i] = newNum2;
                Console.Write(mass2[i] + " ");
            }


            int[] mass3 = new int[n];
            Console.Write("\r\nСодержимое массива №3: ");
            for (int i = 0; i < n; i++)
            {
                var num1 = mass1[i];
                var num2 = mass2[i];
                mass3[i] = num1 * num2;
                Console.Write(mass3[i] + " ");
            }
        }
    }
}