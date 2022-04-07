using System;

namespace N_11word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Самое длинное слово в строке");

            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            var cha = 0;
            var max = 0;
            var maxIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    cha++;
                }

                if (str[i] == ' ')
                {
                    if (cha > max)
                    {
                        max = cha;
                        maxIndex = i;
                    }

                    cha = 0;
                }
            }

            if (cha > max)
            {
                max = cha;
                maxIndex = str.Length - 1;
            }

            Console.Write("Самое длинное слово в строке:");
            for (int i = maxIndex - max; i < maxIndex; i++)
            {
                Console.Write(str[i]);
            }
        }
    }
}