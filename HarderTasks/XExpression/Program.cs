using System;

namespace XExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            ValidateParentheses(expression);

            decimal result = 0;

            int index = 0;
            char symbol = expression[0];
            char operation = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    decimal innerResult = GetParantasesOperationResult(expression, index);
                    index = UpdateIndex(expression, index) - 1;

                    symbol = expression[index];

                    result = GetOperationResult(operation, result, innerResult);

                }
                else if (char.IsDigit(symbol))
                {
                    int symbolInt = ToIntFromChar(symbol);
                    result = GetOperationResult(operation, result, symbolInt);
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

        private static decimal GetParantasesOperationResult(string expression, int index)
        {
            decimal innerResult = 0;
            char innerOperator = '+';
            index++;
            char currentSymbol = expression[index];

            while (currentSymbol != ')')
            {
                if (char.IsDigit(currentSymbol))
                {
                    int currentSymbolInt = ToIntFromChar(currentSymbol);
                    innerResult = GetOperationResult(innerOperator, innerResult, currentSymbolInt);
                }
                else if (currentSymbol == '(')
                {
                    decimal recursionResult  = GetParantasesOperationResult(expression, index);
                    index = UpdateIndex(expression, index);

                    innerResult = GetOperationResult(innerOperator, innerResult, recursionResult);
                }
                else
                {
                    innerOperator = currentSymbol;
                }

                index++;
                currentSymbol = expression[index];
            }

            return innerResult;
        }

        private static int ToIntFromChar(char c)
        {
            return (int)Char.GetNumericValue(c);
        }

        private static decimal GetOperationResult(char operation, decimal mainResult, decimal secondaryResult)
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

        private static void ValidateParentheses(string expression)
        {
            int counter = 0;

            const string messsage = "Invalid Input";

            foreach (char c in expression)
            {
                if (c == '(')
                {
                    counter++;
                }
                else if (c == ')' && counter == 0)
                {
                    Console.WriteLine(messsage);
                    Environment.Exit(0);
                }
                else if (c == ')')
                {
                    counter--;
                }
            }

            if (counter < 0)
            {
                Console.WriteLine(messsage);
                Environment.Exit(0);
            }
        }

        private static int UpdateIndex(string expression, int index)
        {
            int counter = 1;

            index++;

            for (; index < expression.Length; index++)
            {
                char currentChar = expression[index];
               
                if (currentChar == '(')
                {
                    counter++;
                }
                else if (currentChar == ')')
                {
                    counter--;
                }

                if (counter == 0)
                {
                    return index;
                }
            }

            return -1;
        }
    }
}