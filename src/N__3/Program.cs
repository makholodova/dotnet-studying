using System;

namespace N__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Представить натуральное число в виде простых сомножителей");
            Console.WriteLine("Введите натуральное число");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            Console.WriteLine("Множители: ");
            for (int i = 2; i < num; i++)
            {
                var del = false;
                var fact1 = num % i;
                if (fact1 == 0)
                {
                    del = true;
                    for (int j = 2; j < i; j++)
                    {
                        var fact2 = i % j;
                        if (fact2 == 0)
                        {
                            del = false;
                            //Console.WriteLine(j + " ");
                        }
                    }
                }

                if (del)
                {
                    Console.WriteLine("Делитель:" + i);
                    num /= i;
                    i = 1;
                }
            }

            Console.WriteLine("Делитель:" + num);
        }
    }
}