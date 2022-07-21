using System;

namespace PointOnSegment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int right = Math.Max(first, second);
            int left = Math.Min(first, second);

            string inOut = left <= point && point <= right ? "in" : "out";
            int closest = Math.Min(Math.Abs(point - right), Math.Abs(point - left));

            Console.WriteLine(inOut);
            Console.WriteLine(closest);

        }
    }
}