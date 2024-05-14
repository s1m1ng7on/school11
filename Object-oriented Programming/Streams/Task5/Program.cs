using System.Text;

namespace MyApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await EnumerateLines("text.txt");
        }

        public static async Task EnumerateLines(string filepath)
        {
            string[] lines;

            using (StreamReader reader = new StreamReader(filepath, Encoding.UTF8))
            {
                lines = reader.ReadToEnd().Split('\n');
            }

            using (StreamWriter writer = new StreamWriter(filepath, false, Encoding.UTF8))
            {
                int lineIndex = 1;
                foreach (string line in lines)
                {
                    string enumeratedLine = $"{lineIndex}. {line}";

                    writer.WriteLine(enumeratedLine);
                    Console.WriteLine(enumeratedLine);

                    lineIndex++;
                }
            }
        }
    }
}