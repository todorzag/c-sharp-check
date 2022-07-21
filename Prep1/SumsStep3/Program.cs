using System;

namespace SumsStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < n; i ++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    sum1 += currNum;
                }
                if (i % 3 == 1)
                {
                    sum2 += currNum;
                }
                if (i % 3 == 2)
                {
                    sum3 += currNum;
                }
            }

            printSums(sum1, sum2, sum3);
        }

        private static void printSums (int s1, int s2, int s3)
        {
            Console.WriteLine($"sum1 = {s1}");
            Console.WriteLine($"sum2 = {s2}");
            Console.WriteLine($"sum3 = {s3}");
        }

    }
}