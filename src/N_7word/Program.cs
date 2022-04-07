using System;
using System.Drawing;

namespace N_7word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удаление из строки повторяющихся символов");
            var str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine("Строка null");
                return;
            }

            var newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }

                var copyChar = true;
                for (int j = 0; j < newStr.Length; j++)
                {
                    if (str[i] == newStr[j])
                    {
                        copyChar = false;
                        break;
                    }
                }

                if (copyChar == true)
                {
                    newStr += str[i];
                }
            }

            Console.WriteLine(newStr);
        }
    }
}