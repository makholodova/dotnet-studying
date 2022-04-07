using System;

namespace N_2word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество строчных и прописных букв в строке");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            var uppLetters = 0;
            var capitalLetters = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    uppLetters++;
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    capitalLetters++;
                }
            }

            Console.WriteLine("Количество строчных букв: " + uppLetters + "\r\nКоличество прописных букв: " +
                              capitalLetters);
        }
    }
}