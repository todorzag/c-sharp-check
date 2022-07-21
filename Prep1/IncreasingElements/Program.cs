using System;

namespace IncreasingElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = readNums(n);
            int bestStreak = 1;
            int currentStreak = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int currNum = nums[i];
                int nextNum = nums[i + 1];

                if (nextNum > currNum)
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }

                if (bestStreak < currentStreak)
                {
                    bestStreak = currentStreak;
                }
            }

            Console.WriteLine(bestStreak);
        }

        private static int[] readNums (int n)
        {
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            return nums;
        }
    }
}