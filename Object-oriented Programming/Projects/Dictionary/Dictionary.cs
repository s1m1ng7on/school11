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
        public Dictionary<string, List<string>> Words { get; set; }

        public Dictionary()
        {
            Words = LoadDictionary();
        }

        public Dictionary<string, List<string>> LoadDictionary()
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string[] data = StreamHelper.Read("dictionary.txt");

            foreach (string item in data)
            {
                string[] itemArgs = item.Split(' ');
                dictionary.Add(itemArgs[0], itemArgs.Skip(1).ToList());
            }

            return dictionary;
        }

        public void SaveDictionary()
        {
            StreamHelper.Write("dictionary.txt", false, Words);
            LoadDictionary();
        }
    }
}
