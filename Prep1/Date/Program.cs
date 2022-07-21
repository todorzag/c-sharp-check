using System;
using System.Linq;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int[] months30 = { 4, 6, 9, 11 };

            int after5 = day + 5;
            int daysInMonth = 31;

            if (month == 2)
                daysInMonth = 28;

            if (months30.Contains(month))
                daysInMonth = 30;

            if (after5 > daysInMonth)
            {
                after5 -= daysInMonth;
                month++;

                if(month > 12)
                {
                    month = 1;
                }
            }

            Console.WriteLine("{0}.{1:D2}", after5, month);

        }
    }
}