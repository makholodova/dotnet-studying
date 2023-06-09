using System;

namespace N4_leetcode;

internal class Program
{
    /*Учитывая массив целых чисел nums и целое число target, верните индексы двух чисел так,
     чтобы они составляли в суммеtarget .
    Вы можете предположить, что каждый вход будет иметь ровно одно решение , 
    и вы не можете использовать один и тот же элемент дважды.
    Вы можете вернуть ответ в любом порядке.*/

    private static void Main(string[] args)
    {
        var target = 9;
        var nums = new int[] { 2, 7, 11, 15 };
        for (var i = 0; i < nums.Length-1; i++)
        for (var j = i+1; j < nums.Length; j++)
        { if (nums[i] + nums[j] == target) 
            Console.WriteLine(i + "," + j);
        }

       
        // var index = new int[] { };
    }

   
}