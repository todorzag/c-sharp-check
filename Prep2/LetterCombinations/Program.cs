using System;

namespace LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char exclude = char.Parse(Console.ReadLine());

            int totalNum = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (i != exclude&& j != exclude && k != exclude)
                        {
                            Console.Write($"{i}{j}{k} ");
                            totalNum++;
                        }
                    }
                }
            }

            Console.WriteLine(totalNum);
        }
    }
}