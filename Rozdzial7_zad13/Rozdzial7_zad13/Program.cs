using System;

namespace Rozdzial7_zad13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13. Write a program, which creates a rectangular array with size of n by m elements.The dimensions and the elements should be read from theconsole.Find a platform with size of(3, 3) with a maximal sum.");

            // Declare and initialize the matrix
            int[,] matrix = {
            { 0, 2, 4, 0, 9, 5 },
            { 7, 1, 3, 3, 2, 1 },
            { 1, 3, 9, 8, 5, 6 },
            { 4, 6, 7, 9, 1, 0 }
            };
            // Find the maximal sum platform of size 2 x 2
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            // Print the result
            Console.WriteLine("The best platform is:");
            Console.WriteLine(" {0} {1} {2}",
            matrix[bestRow, bestCol],
            matrix[bestRow, bestCol + 1],
            matrix[bestRow, bestCol + 2]);
            Console.WriteLine(" {0} {1} {2}",
            matrix[bestRow + 1, bestCol],
            matrix[bestRow + 1, bestCol + 1],
            matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}",
            matrix[bestRow + 2, bestCol],
            matrix[bestRow + 2, bestCol + 1],
            matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);

            Console.ReadKey();
        } 
    }
}
