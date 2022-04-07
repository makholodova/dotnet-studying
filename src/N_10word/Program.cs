using System;

namespace N_10word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Замена подстроки");

            Console.WriteLine("Строка: ");
            var str = Console.ReadLine();
            Console.WriteLine("Подстрока для замены: ");
            var substr = Console.ReadLine();
            Console.WriteLine("Новую подстрока: ");
            var substrNew = Console.ReadLine();
            Console.WriteLine("Новая строка: ");

            var ind = str.IndexOf(substr);
            var ind2 = ind + substr.Length;
            var length = str.Length - ind - substr.Length;

            var strNew = str.Substring(0, ind) + substrNew +
                         str.Substring(ind2, length);
            //var strNew22 = str.Replace(substr, strNew);

            Console.WriteLine(strNew);
        }
    }
}