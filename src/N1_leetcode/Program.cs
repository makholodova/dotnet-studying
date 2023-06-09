using System;

namespace N1_leetcode;

internal class Program
{
    /*Дан массив nums, состоящий из 2nэлементов вида .[x1,x2,...,xn,y1,y2,...,yn]
      Вернуть массив в виде .[x1,y1,x2,y2,...,xn,yn]*/

    private static void Main(string[] args)
    {
        //public int[] Shuffle(int[] nums, int n) 
        var n = 4;
        var array = new int[n * 2];
        for (var i = 0; i < array.Length; i++)
        {
            var numStr = Console.ReadLine();
            var num = int.Parse(numStr);
            array[i] = num;
        }

        var arrayNew = new int[n * 2];

        for (var i = 0; i < n; i++)
        {
            arrayNew[i * 2] = array[i];
            arrayNew[i * 2 + 1] = array[n + i];
        }

        Console.Write("Содержимое массива: ");

        for (var i = 0; i < arrayNew.Length; i++) Console.Write(arrayNew[i] + " ");
    }
    
}