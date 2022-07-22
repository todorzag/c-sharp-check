using System;

namespace Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());
            decimal firstTime = decimal.Parse(Console.ReadLine());
            decimal secondTime = decimal.Parse(Console.ReadLine());
            decimal finishTime = decimal.Parse(Console.ReadLine());

            int minInHour = 60;

            decimal initialDistance = speed * (firstTime / minInHour);
            decimal speedAfterRaise = speed + ((speed * 10) / 100);
            decimal afterRaise = speedAfterRaise * (secondTime / minInHour);
            decimal speedAfterDecrease = (speedAfterRaise - ((speedAfterRaise * 5) / 100));
            decimal afterDecrease = speedAfterDecrease * (finishTime / minInHour);

            Console.WriteLine($"{initialDistance + afterRaise + afterDecrease:0.00}");
        }
    }
}