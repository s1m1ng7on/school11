using System.Text;

namespace Task8
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await SortNames();
        }

        public static async Task SortNames()
        {
            string[] names;

            using (StreamReader reader = new StreamReader("names.txt", Encoding.UTF8))
                names = reader.ReadToEnd().Split("\n");
            
            Array.Sort(names);

            using (StreamWriter writer = new StreamWriter("sorted-names.txt", false, Encoding.UTF8))
            {
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                    Console.WriteLine(name);
                }
            }
        }
    }
}