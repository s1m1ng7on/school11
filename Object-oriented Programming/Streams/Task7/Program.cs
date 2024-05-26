using System.Diagnostics;
using System.Text;

namespace Task7
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            int[,] matrix = await GetMatrix("matrix.txt");
            WriteLargestSubmatrix(matrix);
        }

        public static async Task<int[,]> GetMatrix(string filepath)
        {
            int[,] matrix;

            using (StreamReader reader = new StreamReader(filepath, Encoding.UTF8))
            {
                int matrixLength = int.Parse(reader.ReadLine());
                matrix = new int[matrixLength, matrixLength];

                for (int i = 0; i < matrixLength; i++)
                {
                    int[] rowNumbers = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int j = 0; j < matrixLength; j++)
                    {
                        matrix[i, j] = rowNumbers[j];
                    }
                }
            }

            return matrix;
        }

        public static void WriteLargestSubmatrix(int[,] matrix)
        {
            int largestSubmatrixSum = int.MinValue;

            for (int i = 0; i <= matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 2; j++)
                {
                    int submatrixSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (submatrixSum > largestSubmatrixSum)
                        largestSubmatrixSum = submatrixSum;
                }
            }

            using (StreamWriter writer = new StreamWriter("largest-submatrix-sum.txt", false, Encoding.UTF8))
            {
                writer.WriteLine(largestSubmatrixSum);
                Console.WriteLine(largestSubmatrixSum);
            }
        }
    }
}