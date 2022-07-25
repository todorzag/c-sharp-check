using System;
using System.Collections.Generic;

namespace FiveSpecialLetters
{
    internal class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            char[] letters = { 'a', 'b', 'c', 'd', 'e' };
            List<string> words = new List<string>();

            string currWord;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int m = 0; m < 5; m++)
                            {
                                currWord = $"{letters[i]}{letters[j]}{letters[k]}{letters[l]}{letters[m]}";
                                int currWeight = CheckWeight(currWord);

                                if (start <= currWeight && currWeight <= end)
                                {
                                    words.Add(currWord);
                                }

                            }
                        }
                    }
                }
            }

            PrintWords(words);
        }

        private static int CheckWeight(string word)
        {
            string newWord = "";
            int weight = 0;

            foreach (char c in word)
            {
                if (!newWord.Contains(c))
                {
                    newWord += c;
                }
            }

            for (int i = 0; i < newWord.Length; i++)
            {
                weight += (i + 1) * GetWeight(newWord[i]);
            }

            return weight;
        }

        private static int GetWeight(char letter)
        {
            switch (letter)
            {
                case 'a': return 5;
                case 'b': return -12;
                case 'c': return 47;
                case 'd': return 7;
                case 'e': return -32;
            }

            return 0;
        }

        private static void PrintWords(List<string> words)
        {
            if (words.Count != 0)
            {
                foreach (string word in words)
                {
                    Console.Write(word + " ");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}