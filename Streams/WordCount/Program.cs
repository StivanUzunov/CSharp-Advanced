using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader(@"../../../words.txt");
            List<string> words = new List<string>();

            while (true)
            {
                string word = reader.ReadLine();
                if (word == null)
                {
                    break;
                }
                words.Add(word);
            }

            using StreamReader readText = new StreamReader(@"../../../text.txt");
            List<string> textToSearch = new List<string>();
            char[] chars = new char[] { '-', '.', ',', '?', '!', ' ' };
            while (true)
            {
                string line = readText.ReadLine();
                if (line == null)
                {
                    break;
                }
                textToSearch.AddRange(line.ToLower().Split(chars, StringSplitOptions.RemoveEmptyEntries));
            }

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount.Add(word, 0);
                while (textToSearch.Contains(word))
                {
                    wordsCount[word]++;
                    textToSearch.RemoveAt(textToSearch.IndexOf(word));
                }
            }

            using StreamWriter actualWriter = new StreamWriter(@"../../../actualResult.txt");
            foreach (var kvp in wordsCount)
            {
                actualWriter.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            using StreamWriter expectedWriter = new StreamWriter(@"../../../expectedResult.txt");
            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                expectedWriter.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
