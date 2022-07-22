using System;
using System.Collections.Generic;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double totalGrade = 0;

            Dictionary<string, int> categories = new Dictionary<string, int>
            {
                {"Top students", 0 }, {"Between 4.00 and 4.99", 0}, {"Between 3.00 and 3.99", 0}, {"Fail", 0}
            };

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrade += grade;

                if (grade < 3)
                {
                    categories["Fail"]++;
                }
                else if (grade <= 3.99)
                {
                    categories["Between 3.00 and 3.99"]++;
                }
                else if (grade <= 4.99)
                {
                    categories["Between 4.00 and 4.99"]++;
                }
                else
                {
                    categories["Top students"]++;
                }
            }

            double average = totalGrade / students;

            foreach (KeyValuePair<string, int> kvp in categories)
            {
                double percent = (kvp.Value / students) * 100;
                Console.WriteLine($"{kvp.Key}: {percent:0.00}%");
            }

            Console.WriteLine($"Average: {average:0.00}");
        }

    }
}