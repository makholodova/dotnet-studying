using Calculator.Core;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var calculator = new SimpleCalculator();
                var num1 = ConsoleHelper.EnterValue();
                var num2 = ConsoleHelper.EnterValue();
                var sign = ConsoleHelper.EnterOperator(); //разобраться
                var res = calculator.Solve(sign, num1, num2);
                ConsoleHelper.PrintResult(res);
                if (!ConsoleHelper.ShouldContinue()) break;
            }
        }
    }
}