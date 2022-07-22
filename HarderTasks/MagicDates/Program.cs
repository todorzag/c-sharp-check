using System;
using System.Linq;

namespace MagicDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(startYear, 1, 1);

            List<DateTime> magicDates = new List<DateTime>();

            while (currentDate.Year <= endYear)
            {
                string year = currentDate.Year.ToString();
                string month = currentDate.Month < 0 ? currentDate.Month.ToString() : $"0{currentDate.Month}";
                string day = currentDate.Day < 0 ? currentDate.Day.ToString() : $"0{currentDate.Day}";

                int dateNum = int.Parse(day + month + year);

                if (CheckIfMagic(dateNum, magicNum))
                {
                    magicDates.Add(currentDate);
                }

                currentDate = currentDate.AddDays(1);
            }

            PrintDates(magicDates);
        }

        private static bool CheckIfMagic (int dateNum, int magicNum)
        {
            int[] arr = GetIntArray(dateNum);
            int currMagicNum = 0;

            int counter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = counter; j < arr.Length; j++)
                {
                    currMagicNum += arr[i] * arr[j];
                }
                counter++;
            }

            return currMagicNum == magicNum;
        }

        private static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        private static void PrintDates (List<DateTime> magicDates)
        {
            if (HasDates(magicDates))
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

        public static bool HasDates<T>(List<T> list)
        {
            if (list.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}