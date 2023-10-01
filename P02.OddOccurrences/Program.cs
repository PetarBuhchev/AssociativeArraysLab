using System;
using System.Collections.Generic;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (string word in input) 
            {
                string wordInLowerCase = word.ToLower();
                if (countWords.ContainsKey(wordInLowerCase))
                {
                    countWords[wordInLowerCase]++;
                }
                else
                {
                    countWords.Add(wordInLowerCase, 1);
                }
            }

            foreach (var word in countWords)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
