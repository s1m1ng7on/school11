using System.Text;

namespace Helpers
{
    public static class StreamHelper
    {
        public static string[] Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    List<string> data = new List<string>();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        data.Add(line);
                    }

                    return data.ToArray();
                }
            }
            else
            {
                return Array.Empty<string>();
            }
        }

        public static void Write(string filePath, bool append, string[] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, append))
            {
                foreach (string item in data)
                    writer.WriteLine(item);
            }
        }
    }
}
