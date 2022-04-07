using System;

namespace N_6word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Составить из букв введенной строки слова");

            Console.WriteLine("Введите строку:");
            var str = Console.ReadLine();
            var lengStr = str.Length;

            Console.WriteLine("Введите кол-во слов:");
            var nStr = Console.ReadLine();
            var n = int.Parse(nStr);
            var rnd = new Random();

            for (int j = 0; j < n; j++)
            {
                var word = "";
                var lengWord = rnd.Next(2, 7);
                var i = 0;

                while (i < lengWord)
                {
                    var indexCha = rnd.Next(lengStr);
                    var cha = str[indexCha];
                    word += cha;
                    i++;
                }

                Console.WriteLine(word);
            }
        }
    }
}