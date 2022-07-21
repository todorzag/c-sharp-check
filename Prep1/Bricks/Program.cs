using System;

namespace Bricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int volume = int.Parse(Console.ReadLine());

            int bricksPerCourse = volume * workers;
            decimal courses = Math.Ceiling((decimal)bricks / bricksPerCourse);

            Console.WriteLine(courses);
        }
    }
}