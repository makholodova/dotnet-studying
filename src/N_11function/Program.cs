using System;

namespace N_11function
{
    class Program
    {
        /*Вводится строка, состоящая из слов, разделенных пробелами. 
            Следует заменить ее на строку, в которой слова идут в обратном порядке 
            по-сравнению с исходной строкой. Вывести измененную строку на экран.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Изменить порядок слов в строке на обратный");
            Console.WriteLine("Введите передложение:");
            var str = Console.ReadLine();
            var newStr = ChangeWordOrderInAString(str);
            Console.WriteLine("Измененное передложение:");
            Console.WriteLine(newStr);
        }

        static string ChangeWordOrderInAString(string str)
        {
            var word = "";
            var newStr = "";
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] != ' ')
                {
                    word += str[j];
                }
                else
                {
                    newStr = word + " " + newStr;
                    word = "";
                }
            }
            
            return word + " " + newStr;
        }
    }
}