using System;
using System.Linq;

namespace ChristmasHat
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int dotCounter = (n * 2) - 1;
            string dots = string.Concat(Enumerable.Repeat(".", dotCounter));

            int dashCounter = 0;
            string dashs = string.Concat(Enumerable.Repeat(".", dashCounter));

            string stars = string.Concat(Enumerable.Repeat("*", (4 * n) + 1));

            Console.WriteLine($"{dots}/|\\{dots}");
            Console.WriteLine($"{dots}\\|/{dots}");

            for (int i = 0; i < n * 2; i++)
            {
                dots = string.Concat(Enumerable.Repeat(".", dotCounter));
                dashs = string.Concat(Enumerable.Repeat("-", dashCounter));

                Console.WriteLine($"{dots}*{dashs}*{dashs}*{dots}");

                dashCounter++;
                dotCounter--;
            }
            Console.WriteLine($"{stars}");

            for (int i = 0; i < (4 * n) + 1; i++)
            {
                string nextToLast = i % 2 == 0 ? "*" : ".";
                Console.Write(nextToLast);
            }
            Console.WriteLine($"\n{stars}");
        }
    }
}