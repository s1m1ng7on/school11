using System;
using System.Text;

namespace Task4
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string[] fileData = 
            {
                await ReadToEnd("file1.txt"),
                await ReadToEnd("file2.txt")
            };

            await Write("file3.txt", fileData);
        }

        static async Task<string> ReadToEnd(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        static async Task Write(string filepath, string[] data)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false, Encoding.UTF8))
            {
                foreach (string item in data)
                {
                    writer.WriteLine(item);
                    Console.WriteLine(item);
                }
            }
        }
    }
}