using System.Text;

namespace Task1
{
    public class Program
    {
        //Insert a valid filepath for a .txt file
        public const string filepath = "C:\\Users\\Simeon Gunev\\Downloads\\Products.txt";

        public static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(filepath, Encoding.UTF8))
            {
                string line;
                int lineIndex = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineIndex % 2 == 1)
                        Console.WriteLine(line);

                    lineIndex++;
                }
            }
        }
    }
}