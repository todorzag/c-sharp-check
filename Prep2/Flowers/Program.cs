using System;

namespace Flowers
{
    internal class Program
    {
        static void Main()
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            bool holiday = Console.ReadLine() == "Y"? true : false;

            decimal chrysanthemumsPrice = 0;
            decimal rosesPrice = 0;
            decimal tulipsPrice = 0;

            double totalPrice = 0;
            int totalFlowers = chrysanthemums + roses + tulips;

            switch (season)
            {
                case "Summer":
                case "Spring":
                    chrysanthemumsPrice = (decimal)(chrysanthemums * 2.00);
                    rosesPrice = (decimal)(roses * 4.10);
                    tulipsPrice = (decimal)(tulips * 2.50);

                    totalPrice = (double)(chrysanthemumsPrice + rosesPrice + tulipsPrice);
                    break;

                case "Winter":
                case "Autumn":
                    chrysanthemumsPrice = (decimal)(chrysanthemums * 3.75);
                    rosesPrice = (decimal)(roses * 4.50);
                    tulipsPrice = (decimal)(tulips * 4.15);

                    totalPrice = (double)(chrysanthemumsPrice + rosesPrice + tulipsPrice);
                    break;
            }

            if (tulips > 7 && season == "Spring")
            {
                totalPrice *= 0.95;
            }
            if (roses >= 10 && season == "Winter")
            {
                totalPrice *= 0.90;
            }
            if (totalFlowers > 20)
            {
                totalPrice *= 0.80;
            }

            if (holiday)
                totalPrice += totalPrice * 0.15;

            Console.WriteLine($"{totalPrice + 2:0.00}");
        }
    }
}