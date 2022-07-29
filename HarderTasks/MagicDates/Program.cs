using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearStart = int.Parse(Console.ReadLine());
            int yearEnd = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(yearStart, 1, 1);

            List<DateTime> magicDates = new List<DateTime>();

            while (currentDate.Year <= yearEnd)
            {
                string dateString = GetCurrentDateString(currentDate);

                if (CheckIfMagic(dateString, magicNum))
                {
                    magicDates.Add(currentDate);
                }

                currentDate = currentDate.AddDays(1);
            }

            PrintDates(magicDates);
        }

        private static bool CheckIfMagic (string dateString, int magicNum)
        {
            int currMagicNum = 0;

            int iterationIndex = 1;

            for (int i = 0; i < dateString.Length; i++)
            {
                for (int j = iterationIndex; j < dateString.Length; j++)
                {
                    currMagicNum += (ToIntFromChar(dateString[i])) * (ToIntFromChar(dateString[j]));
                }
                iterationIndex++;
            }

            return currMagicNum == magicNum;
        }

        private static void PrintDates (List<DateTime> magicDates)
        {
            if (!HasDates(magicDates))
            {
                foreach (DateTime date in magicDates)
                {
                    Console.WriteLine(date.ToString("dd-MM-yyyy"));
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool HasDates<T>(List<T> list)
        {
            return list.Count == 0;
        }

        private static string GetCurrentDateString (DateTime currentDate)
        {
            string year = currentDate.Year.ToString();
            string month = currentDate.Month < 10 ? $"0{currentDate.Month}" : currentDate.Month.ToString();
            string day = currentDate.Day < 10 ? $"0{currentDate.Day}" : currentDate.Day.ToString();

            return day + month + year;
        }

        private static int ToIntFromChar(char c)
        {
            return (int)Char.GetNumericValue(c);
        }
    }
}