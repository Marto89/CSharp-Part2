//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSumOfRectanMatrix
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            string inputArrayOne = Console.ReadLine();
            string[] inputArrayTwo = inputArrayOne.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[rows, col] = int.Parse(inputArrayTwo[col]);
            }
        }
        int maxSum = int.MinValue;
        int [,] realSmallMatrix = new int [3,3];
        for (int rows = 0; rows <=matrix.GetLength(0)-3; rows++)
        {
            for (int col = 0; col <=matrix.GetLength(1)-3; col++)
            {
                int currentSum = 0;
                int [,]currentSmallMatrix = new int [3,3];
                int realRows = 0;
                for (int smallRows = rows; smallRows < rows+3; smallRows++)
                {
                    int realCol = 0;
                    for (int smallCol = col; smallCol < col+3; smallCol++)
                    {
                        currentSum += matrix[smallRows, smallCol];
                        currentSmallMatrix [realRows,realCol]= matrix[smallRows, smallCol];
                        realCol++;
                    }
                    realRows++;
                }
                if (currentSum > maxSum)
                {
                   realSmallMatrix = (int[,])currentSmallMatrix.Clone();
                   maxSum = currentSum;
                }
            }
        }
        for (int rows = 0; rows < realSmallMatrix.GetLength(0); rows++)
        {
            for (int col = 0; col < realSmallMatrix.GetLength(1); col++)
            {
                Console.Write("{0,2}",realSmallMatrix[rows,col]);
            }
            Console.WriteLine();
        }
    }
}
