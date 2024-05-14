using System.Text;

namespace Task7
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            int[,] matrix = await GetMatrix("matrix.txt");

        }

        public static async Task<int[,]> GetMatrix(string filepath)
        {
            int[,] matrix;

            using (StreamReader reader = new StreamReader(filepath, Encoding.UTF8))
            {
                int matrixLength = int.Parse(reader.ReadLine());
                matrix = new int[matrixLength, matrixLength];

                for (int i )
            }

            return matrix;
        }

        public static async Task WriteSubmatrix(int[,] matrix)
        {
            for (int i = 0; i <= matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 2; j++)
                {
                    int[,] submatrix =
                    {
                        { matrix[i, j], matrix[i, j + 1] },
                        { matrix[i + 1, j], matrix[i + 1, j + 1] }
                    };
                }
            }
        }
    }
}