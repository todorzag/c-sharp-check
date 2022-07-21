using System;
using System.Collections.Generic;
using System.Linq;

namespace Sums3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];

            int[] resultArray = readElements(nums);

            Console.WriteLine(sumOf3(nums));
        }

        private static string sumOf3(int[] nums)
        {
            int sum = 0;
            int maxNum = int.MinValue;
            int minIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];
                sum += currNum;

                if(currNum > maxNum)
                {
                    maxNum = currNum;
                }

                if(currNum < nums[minIndex])
                {
                    minIndex = i;
                }

            }

            string result = "No";

            if (sum > 0 && sum / 2 == maxNum)
            {
                result = $"{nums[minIndex]} + {maxNum - nums[minIndex]} = {maxNum}";
            }

            return result;
        }

        private static int[] readElements(int[] nums)
        {
            int[] result = nums;

            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}