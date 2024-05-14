using System.Linq.Expressions;
using System.Text;

namespace Task6
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                await CompareLines("text1.txt", "text2.txt");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static async Task CompareLines(string filepath1, string filepath2)
        {
            string[] file1Lines, file2Lines;

            using (StreamReader reader1 = new StreamReader(filepath1, Encoding.UTF8))
            {
                using (StreamReader reader2 = new StreamReader(filepath2, Encoding.UTF8))
                {
                    file1Lines = reader1.ReadToEnd().Split("\n");
                    file2Lines = reader2.ReadToEnd().Split("\n");
                }
            }

            if (file1Lines.Length != file2Lines.Length)
                throw new ArgumentException("The files don't have an equal number of lines.");

            int matchingLinesCount = 0;
            int differentLinesCount = 0;

            for (int i = 0; i < file1Lines.Length; i++)
            {
                if (file1Lines[i] == file2Lines[i])
                    matchingLinesCount++;
                else
                    differentLinesCount++;
            }

            Console.WriteLine($"Matching Lines Count: {matchingLinesCount}");
            Console.WriteLine($"Different Lines Count: {differentLinesCount}");
        }
    }
}