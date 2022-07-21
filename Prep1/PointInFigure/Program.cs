using System;

namespace PointInFigure
{
    internal class Program
    {
        public static bool CheckRect1(int x, int y)
        {
            return x >= 4 && x <= 10 && y >= -5 && y <=3;
        }

        public static bool CheckRect2(int x, int y)
        {
            return y >= -3 && y <= 1 && x >= 2 && x <= 12;
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            string result = CheckRect1(x, y) || CheckRect2(x, y) ? "in" : "out";

            Console.WriteLine(result);
        }
    }
}