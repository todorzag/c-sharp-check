using System;
using System.Collections.Generic;

namespace CrossingSequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trib1 = int.Parse(Console.ReadLine());
            int trib2 = int.Parse(Console.ReadLine());
            int trib3 = int.Parse(Console.ReadLine());

            List<int> tribonacci = tribonacciSequence(trib1, trib2, trib3);

            int spiralCurr = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());

            List<int> spiral = spiralSequence(spiralCurr, spiralStep);

            Console.WriteLine(commonElements(tribonacci, spiral));
        }

        private static List<int> tribonacciSequence (int trib1, int trib2, int trib3)
        {
            int tribCurr = trib3;
            List<int> tribonacci = new List<int> { trib1, trib2, trib3 };

            while (tribCurr < 1000000)
            {
                tribCurr = trib1 + trib2 + trib3;

                tribonacci.Add(tribCurr);

                trib1 = trib2;
                trib2 = trib3;
                trib3 = tribCurr;
            }

            return tribonacci;
        }

        private static List<int> spiralSequence(int spiralCurr, int spiralStep)
        {
            List<int> spiral = new List<int> { spiralCurr };

            int spiralCount = 0;
            int spiralStepMul = 1;

            while (spiralCurr < 1000000)
            {
                spiralCurr += spiralStep * spiralStepMul;

                spiral.Add(spiralCurr);
                spiralCount++;

                if (spiralCount % 2 == 0)
                {
                    spiralStepMul++;
                }
            }

            return spiral;
        }

        public static string commonElements(List<int> iArr1, List<int> iArr2)
        {
            string result = "No";
            int index2 = 0, index1 = 0;

            while (index2 < iArr2.Count && index1 < iArr1.Count)
            {
                int left1 = 0, right1 = (iArr1.Count) - 1;

                while (left1 <= right1)
                {
                    int mid1 = (left1 + right1) / 2;
                    if (iArr2[index2] == iArr1[mid1])
                    {
                        result = $"{iArr1[mid1]}";
                        return result;
                    }
                    else if (iArr2[index2] > iArr1[mid1])
                        left1 = mid1 + 1;
                    else right1 = mid1 - 1;
                }

                index2++; 
            }

            return result;
        }
    }
}