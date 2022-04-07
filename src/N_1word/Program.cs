using System;

namespace N_1word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество слов в строке");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            bool flag = true;
            var word = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var cha = str[i];
                if (cha != ' ' && flag == true)
                {
                    word++;
                    flag = false;
                    continue;
                }

                if (cha == ' ')
                {
                    flag = true;
                }
            }

            Console.WriteLine("Количество слов в строке: " + word);
        }
    }
}