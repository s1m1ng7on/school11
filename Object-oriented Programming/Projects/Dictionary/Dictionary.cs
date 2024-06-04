using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Dictionary
{
    public class Dictionary
    {
        public Dictionary<string, List<string>> Words { get; set; } = new Dictionary<string, List<string>>();

        public Dictionary()
        {
            LoadDictionary();
        }

        public void LoadDictionary()
        {
            if (Words.Count > 0)
                Words.Clear();

            string[] data = StreamHelper.Read("dictionary.txt");

            foreach (string item in data)
            {
                string[] itemArgs = item.Split(" | ");
                Words.Add(itemArgs[0], itemArgs.Skip(1).ToList());
            }
        }

        public void SaveDictionary()
        {
            StreamHelper.Write("dictionary.txt", false, ToDataString());
            LoadDictionary();
        }

        private string[] ToDataString()
        {
            return Words.Select(w => $"{w.Key} {string.Join(" ", w.Value)}").ToArray();
        }
    }
}
