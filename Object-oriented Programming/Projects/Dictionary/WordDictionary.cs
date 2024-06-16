using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Dictionary
{
    public class WordDictionary
    {
        public SortedDictionary<string, List<string>> Words { get; set; } = new SortedDictionary<string, List<string>>();

        public WordDictionary()
        {
            string[] data = StreamHelper.Read("dictionary.txt");

            foreach (string item in data)
            {
                string[] itemArgs = item.Split(" | ");
                Words.Add(itemArgs[0], itemArgs.Skip(1).ToList());
            }
        }

        public void Add(string word, string definition)
        {
            if (!Words.ContainsKey(word))
                Words.Add(word, new List<string>());

            Words[word].Add(definition);

            Save();
        }

        public void Save()
        {
            StreamHelper.Write("dictionary.txt", false, ToDataString());
        }

        public KeyValuePair<string, List<string>> FindWord(string word)
        {
            return Words.Where(w => w.Key == word).FirstOrDefault();
        }

        private string[] ToDataString()
        {
            return Words.Select(w => $"{w.Key} | {string.Join(" | ", w.Value)}").ToArray();
        }
    }
}
