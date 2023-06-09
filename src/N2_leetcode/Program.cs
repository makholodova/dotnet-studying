using System;

namespace N2_leetcode;

internal class Program
{
    /*Вам дано неотрицательное число с плавающей запятой, округленное до двух знаков после запятой celsius, которое обозначает температуру
     в градусах Цельсия .
      Вы должны преобразовать градусы Цельсия в Кельвины и Фаренгейты и вернуть их в виде массива ans = [kelvin, fahrenheit].
      Вернуть массив ans. Ответы в пределах фактического ответа будут приняты.10-5
      Обратите внимание, что:
      Kelvin = Celsius + 273.15
      Fahrenheit = Celsius * 1.80 + 32.00*/

    private static void Main(string[] args)
    {
        Console.WriteLine("temperature in Celsius");
        var celsiusStr = Console.ReadLine();
        var celsius = double.Parse(celsiusStr);
        if (0 < celsius && celsius <= 1000)
        {
            var kelvin = celsius + 273.15;
            var fahrenheit = celsius * 1.80 + 32.00;
            var ans = new[] { Math.Round(kelvin, 5), Math.Round(fahrenheit, 5) };
            Console.WriteLine(" Kelvin: " + ans[0] + "\r\n Fahrenheit: " + ans[1]);
            //Console.WriteLine(" Kelvin: " + string.Format("{0:F5}", ans[0]) + "\r\n Fahrenheit: " + "{0:0.00000}",ans[1]);
        }
        else
        {
            Console.WriteLine("temperature is non-negative float");
        }

        
    }
}