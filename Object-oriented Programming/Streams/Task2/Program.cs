using System.Text;

namespace Task2
{
    public class Program
    {
        //Insert a valid filepath for a .txt file
        public const string inputFilepath = "C:\\Users\\Simeon Gunev\\Downloads\\Products.txt";

        public static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(inputFilepath, Encoding.UTF8))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    string readerLine;
                    int lineIndex = 1;

                    while ((readerLine = reader.ReadLine()) != null)
                    {
                        string writerLine = $"Line {lineIndex}: {readerLine}";

                        writer.WriteLine(writerLine);
                        Console.WriteLine(writerLine);

                        lineIndex++;
                    }
                }
            }
        }
    }
}