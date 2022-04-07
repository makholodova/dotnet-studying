using System;
using System.Collections.Generic;

namespace N__4v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести количество делителей и делители числа");
            Console.WriteLine("Введите первое значение диапозона");
            var num1Str = Console.ReadLine();
            var num1 = int.Parse(num1Str);
            Console.WriteLine("Введите второе значение диапозона");
            var num2Str = Console.ReadLine();
            var num2 = int.Parse(num2Str);
            Console.WriteLine("Введите количество делителей числа");
            var nStr = Console.ReadLine();
            var nCon = int.Parse(nStr);
            for (int i = num1; i <= num2; i++)
            {
                int n = 0;
                int k = 0;
                var mas = new int[i];
                var list = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    var fact = i % j;
                    if (fact == 0)
                    {
                        list.Add(j);
                        mas[n] = j;
                        n++;
                    }
                }

                if (n >= nCon)
                {
                    Console.WriteLine("\r\nКоличество делителей числа " + i + " : " + n);
                    Console.Write("NEW Делители числа " + i + ": ");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(mas[j] + ", ");
                    }

                    Console.Write("NEW2 Делители числа " + i + ": ");
                    foreach (var j in list)
                    {
                        Console.Write(j + ", ");
                    }

                    Console.Write("OLD Делители числа " + i + ": ");
                    for (int j = 1; j <= i; j++)
                    {
                        var fact = i % j;
                        if (fact == 0)
                        {
                            Console.Write(j + ", ");
                        }
                    }
                }
            }
        }
    }
}