using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var wordNSyn = new Dictionary<string, List<string>>();
            List<string> words = new List<string>();

            for (int i = 0; i < num*2; i++) 
            {
                string wordInputInArray = Console.ReadLine();
                words.Add(wordInputInArray);
            }

            for (int i = 0; i < num*2; i++) 
            {
                for (int j = 0; j < words.Count; j++) 
                {
                if (!wordNSyn.ContainsKey(words[j]))
                {
                        wordNSyn.Add(words[j], new List<string>());
                        wordNSyn[words[j]].Add(words[j+1]);
                        i++;
                        words.RemoveAt(j);
                        words.RemoveAt(j);
                        break;
                }
                    else
                    {
                        wordNSyn[words[j]].Add(words[j + 1]);
                        i++;
                        words.RemoveAt(j);
                        words.RemoveAt(j);
                        break;
                    }

                }
            }

            foreach (var word in wordNSyn) 
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
