//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceEqualStrings
{
    class LongestSequenceEqualStrings
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string[,] realMatrix = new string[n, m];
            for (int rows = 0; rows < realMatrix.GetLength(0); rows++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                for (int cols = 0; cols < realMatrix.GetLength(1); cols++)
                {
                    realMatrix[rows, cols] = inputArray[cols];
                }
            }

            const int VerticalSequence = 0;
            const int HorizontalSequence = 1;
            const int DiagonalSequenceRight = 2;
            const int DiagonalSequenceLeft = 3;

            int[] deltaX = new int[] { 1, 0, 1, 1 };
            int[] deltaY = new int[] { 0, 1, 1, -1 };

            int[, ,] dp = new int[n, m, 4];

            int maximalLength = 0;
            int bestRow = 0, bestCol = 0;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    for (int k = 0; k < 4; ++k)
                    {
                        dp[i, j, k] = 1;
                    }

                    if (i > 0 && realMatrix[i, j]==(realMatrix[i - 1, j]))
                    {
                        dp[i, j, VerticalSequence] = dp[i - 1, j, VerticalSequence] + 1;
                    }
                    if (j > 0 && realMatrix[i, j]==(realMatrix[i, j - 1]))
                    {
                        dp[i, j, HorizontalSequence] = dp[i, j - 1, HorizontalSequence] + 1;
                    }
                    if (i > 0 && j > 0 && realMatrix[i, j]==(realMatrix[i - 1, j - 1]))
                    {
                        dp[i, j, DiagonalSequenceRight] = dp[i - 1, j - 1, DiagonalSequenceRight] + 1;
                    }
                    if (i > 0 && j < n - 1 && realMatrix[i, j]==(realMatrix[i - 1, j + 1]))
                    {
                        dp[i, j, DiagonalSequenceLeft] = dp[i - 1, j + 1, DiagonalSequenceLeft] + 1;
                    }

                    for (int k = 0; k < 4; ++k)
                    {
                        if (dp[i, j, k] > maximalLength)
                        {
                            maximalLength = dp[i, j, k];
                            bestRow = i;
                            bestCol = j;
                        }
                    }
                }
            }

            Console.WriteLine("The longest sequence is with length: " + maximalLength);
            Console.WriteLine("The value of the repeating string is: " + realMatrix[bestRow, bestCol]);
        }
    }
}