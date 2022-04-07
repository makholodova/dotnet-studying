using System;

namespace N_8word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Самая длинная строка в массиве");
            Console.WriteLine("Введите кол-во строк");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            Console.WriteLine("Введите строки");
            string[] mass = new string[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = Console.ReadLine();
            }

            var numMax = 0;
            for (int i = 0; i < n; i++)
            {
                var str = mass[i];
                if (str.Length > numMax)
                {
                    numMax = str.Length;
                }
            }

            Console.WriteLine("Номер(a) самой длинной строки: ");
            for (int i = 0; i < n; i++)
            {
                var str = mass[i];
                if (str.Length == numMax)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}