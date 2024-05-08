using System.Reflection.PortableExecutable;
using System.Text;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> wordMatches = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader("words.txt", Encoding.UTF8))
            {
                using (StreamReader textReader = new StreamReader("text.txt", Encoding.UTF8))
                {
                    string text = textReader.ReadToEnd();

                    string currentWord;
                    while ((currentWord = wordsReader.ReadLine()) != null)
                    {
                        wordMatches.Add(currentWord, MatchesCount(currentWord, text));
                    }
                }
            }

            var sortedWordMatches = wordMatches.OrderByDescending(m => m.Value);

            using (StreamWriter resultWriter = new StreamWriter("result.txt"))
            {
                foreach (KeyValuePair<string, int> wordMatch in sortedWordMatches)
                {
                    string resultLine = $"{wordMatch.Key} - {wordMatch.Value}";

                    resultWriter.WriteLine(resultLine);
                    Console.WriteLine(resultLine);
                }
            }
        }

        private static int MatchesCount(string word, string text)
        {
            int count = 0;
            int index = 0;

            while (index < text.Length)
            {
                if (text[index] == word[0])
                {
                    if (text.Substring(index, word.Length) == word)
                    {
                        count++;
                        index += word.Length;
                    }
                }
                else
                {
                    index++;
                }
            }

            return count;
        }
    }
}