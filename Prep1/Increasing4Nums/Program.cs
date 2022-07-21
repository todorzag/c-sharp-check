using System;

namespace Increasing4Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            bool check = false;

            for (int i = from; i <= to; i++)
            {
                for (int j = i + 1; j <= to; j++)
                {
                    for (int k = j + 1; k <= to; k++)
                    {
                        for (int l = k + 1; l <= to; l++)
                        {
                            Console.WriteLine($"{i}{j}{k}{l}");
                            check = true;
                        }
                    }
                }
            }

            if (!check)
                Console.WriteLine("No");
        }
    }
}