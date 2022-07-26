using System;

namespace XExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            decimal result = 0;

            int index = 0;
            char symbol = expression[0];
            char operation = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    (decimal innerResult, index) = GetParantasesOperationResult(expression, index);

                    symbol = expression[index];

                    result = NormalSwitch(operation, result, innerResult);

                }
                else if (char.IsDigit(symbol))
                {
                    result = SwitchWithSymbol(operation, result, symbol);
                }
                else
                {
                    operation = symbol;
                }

                index++;
                symbol = expression[index];
            }

            Console.WriteLine($"{result:0.00}");
        }

        private static (decimal, int) GetParantasesOperationResult(string expression, int index)
        {
            decimal innerResult = 0;
            char innerOperator = '+';
            index++;
            char currentSymbol = expression[index];

            while (currentSymbol != ')')
            {
                if (char.IsDigit(currentSymbol))
                {
                    innerResult = SwitchWithSymbol(innerOperator, innerResult, currentSymbol);
                }
                else if (currentSymbol == '(')
                {
                    (decimal recursionResult, index)  = GetParantasesOperationResult(expression, index);

                    innerResult = NormalSwitch(innerOperator, innerResult, recursionResult);
                }
                else
                {
                    innerOperator = currentSymbol;
                }

                index++;
                currentSymbol = expression[index];
            }

            return (innerResult, index);
        }

        private static decimal SwitchWithSymbol(char operation, decimal result, char symbol)
        {
            switch (operation)
            {
                case '+':
                    result += symbol - '0';
                    break;
                case '-':
                    result -= symbol - '0';
                    break;
                case '*':
                    result *= symbol - '0';
                    break;
                case '/':
                    result /= symbol - '0';
                    break;
            }

            return result;
        }

        private static decimal NormalSwitch(char operation, decimal mainResult, decimal secondaryResult)
        {
            switch (operation)
            {
                case '+':
                    mainResult += secondaryResult;
                    break;
                case '-':
                    mainResult -= secondaryResult;
                    break;
                case '*':
                    mainResult *= secondaryResult;
                    break;
                case '/':
                    mainResult /= secondaryResult;
                    break;
            }

            return mainResult;
        }
    }
}