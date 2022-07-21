using System;

namespace CrossingSequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tribonachi = new int[3];
            ReadTribonachi(tribonachi);

            int spiral1 = int.Parse(Console.ReadLine());
            int spiral2 = int.Parse(Console.ReadLine());

            bool found = false;

            while (tribonachi[2] < 1000000 && spiral1 < 1000000)
            {
                int buffer = trib1 + trib2 + trib3;
                

                spiral1 += spiral2;

                if (trib3 == spiral1)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{trib3}");
            else
                Console.WriteLine("No");
        }

        private static int[] ReadTribonachi(int[] tribonachi)
        {
            

            tribonachi[0] = int.Parse(Console.ReadLine());
            tribonachi[1] = int.Parse(Console.ReadLine());
            tribonachi[2] = int.Parse(Console.ReadLine());

            return tribonachi;
        }
    }
}