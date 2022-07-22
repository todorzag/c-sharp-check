using System;

namespace ChangeTiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal moneyGathered = decimal.Parse(Console.ReadLine());
            decimal floorWidth = decimal.Parse(Console.ReadLine());
            decimal floorLength = decimal.Parse(Console.ReadLine());
            decimal triangleSide = decimal.Parse(Console.ReadLine());
            decimal triangleHeight = decimal.Parse(Console.ReadLine());
            decimal oneTilePrice = decimal.Parse(Console.ReadLine());
            decimal workmanPrice = decimal.Parse(Console.ReadLine());

            decimal floorArea = floorWidth * floorLength;
            decimal tileArea = (triangleSide * triangleHeight) / 2;
            decimal tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;
            decimal finalSum = (tilesNeeded * oneTilePrice) + workmanPrice;

            decimal diff = Math.Abs(finalSum - moneyGathered);

            string result = finalSum > moneyGathered ? $"You'll need {diff:0.00} lv more." : $"{diff:0.00} lv left.";

            Console.WriteLine(result);
        }
    }
}