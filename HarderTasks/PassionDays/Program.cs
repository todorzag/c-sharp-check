using System;

namespace PassionDays
{
    internal class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            int purchases = 0;

            while (action != "mall.Exit")
            {
                action = Console.ReadLine();

                if (action == "mall.Exit") { break; };

                char[] chars = action.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    char currChar = chars[i];

                    if (currChar == '%')
                    {
                        purchases++;
                        money /= 2;
                    }
                    else if (currChar == '*')
                    {
                        money += 10;
                    } 
                    else if (!Char.IsDigit(currChar))
                    {
                        decimal price = GetDiscount(currChar);

                        if (money < price)
                        {
                            continue;
                        }

                        purchases++;
                        money -= price;
                    }
                }
            }

            Console.WriteLine($"{purchases} purchases. Money left: {money:0.00} lv.");
        }

        private static decimal GetDiscount (char character)
        {
            decimal asciiVal = (int)character;

            if (Char.IsLower(character))
            {
                asciiVal *= 0.30m;
            }
            else
            {
                asciiVal *= 0.50m;
            }

            return asciiVal;
        }
    }
}