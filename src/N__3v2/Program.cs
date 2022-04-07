using System;

namespace N__3v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Представить натуральное число в виде простых сомножителей");
            Console.WriteLine("Введите натуральное число");
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);

            for (var i = 2; i <= num;)
            {
                var res = num % i;
                if (res == 0)
                {
                    // i является простым сомножителем поэтому его увеличивать ненужно
                    // нужно разделить натуральное число на этот сомножитель
                    num /= i;
                    Console.WriteLine("Делитель:{0}. Натуральное число:{1}", i, num);
                }
                else
                {
                    // i не является простым сомножителем поэтому его нужно увеличить
                    i++;
                }
            }
        }
    }
}