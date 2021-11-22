﻿using System;

namespace Rozdzial10_zad10
{
    class Program
    {
        static int numberOfPaths(int m, int n)
        {
            int[,] count = new int[m, n];

            for (int i = 0; i < m; i++)
                count[i, 0] = 1;

            for (int j = 0; j < n; j++)
                count[0, j] = 1;

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    count[i, j] = count[i - 1, j] + count[i, j - 1];

            return count[m - 1, n - 1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("10. You are given a matrix with passable and impassable cells. Write a recursive program that finds all paths between two cells in the matrix.");

            Console.WriteLine("Possible paths: {0}", numberOfPaths(3, 3));

            Console.ReadKey();
        }
    }
}
