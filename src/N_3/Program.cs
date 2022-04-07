using System;
using System.Runtime.InteropServices;

namespace N_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверим выражение (1+2+...+n = n*(n+1)/2)");
            Console.WriteLine("Ввведите значение n ");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            int v = n * (n + 1) / 2;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            if (v == sum)
            {
                Console.Write("Равенство выполняется:" + v + "=" + sum);
            }
            else
            {
                Console.WriteLine("Равенство не выполняется");
            }

            Console.ReadLine();
        }
    }
}