using System;

namespace PassionDays
{
    internal class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            int numberOfPurchases = 0;

            action = WaitCommand(action);

            while (action != "mall.Exit")
            {
                char[] chars = action.ToCharArray();

                foreach (char currChar in chars)
                {
                    if (currChar == '%')
                    {
                        numberOfPurchases++;
                        money /= 2;
                    }
                    else if (currChar == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        decimal price = GetDiscount(currChar);

                        if (money > price)
                        {
                            numberOfPurchases++;
                            money -= price;
                        }
                    }
                }

                action = Console.ReadLine();
            }

            if (numberOfPurchases > 0)
            {
                Console.WriteLine($"{numberOfPurchases} purchases. Money left: {money:0.00} lv.");
            }
            else
            {
                Console.WriteLine($"No purchases. Money left: {money:0.00} lv.");
            }
        }

        private static decimal GetDiscount (char character)
        {
            decimal discount = (int)character;

            if (Char.IsLower(character))
            {
                discount *= 0.30m;
            }
            else if (Char.IsUpper(character))
            {
                discount *= 0.50m;
            }


            return discount;
        }

        private static string WaitCommand (string action)
        {
            while (action != "mall.Enter")
            {
                action = Console.ReadLine();
            }

            action = Console.ReadLine();

            return action;
        }
    }
}