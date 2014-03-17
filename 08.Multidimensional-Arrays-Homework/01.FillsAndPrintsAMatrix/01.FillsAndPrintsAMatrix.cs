//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4).

using System;
class FillsAndPrintsAMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintMatrix(MatrixA(n));
        PrintMatrix(MatrixB(n));
        PrintMatrix(MatrixC(n));
        PrintMatrix(MatrixD(n));
    }
    static int[,]MatrixA(int n)
    {
        int[,] matrix = new int[n, n];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int counter = rows;
            counter++;
            for (int col = 0; col < matrix.GetLength(1); col++, counter += n)
            {
                matrix[rows, col] = counter;
            }
        }
        return matrix;
    }
    static int[,]MatrixB(int n)
    {
        int[,] matrix = new int[n, n];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int counter = rows;
            int counter2 = 0;
            counter++;
            for (int col = 0; col < matrix.GetLength(1); col++, counter += n)
            {
                if (col % 2 == 0)
                {
                    matrix[rows, col] = counter;
                }
                else
                {
                    counter2 = n * (col + 1);
                    counter2 -= rows;
                    matrix[rows, col] = counter2;
                }
            }
        }
        return matrix;
    }
    static int[,]MatrixC(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
        {
            for (int col = 0; col < n - rows; col++)
            {
                matrix[(rows + col), col] = counter;
                counter++;
            }
        }
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            for (int rows = 0; rows < n - col; rows++)
            {
                matrix[rows, (rows + col)] = counter;
                counter++;
            }
        }
        return matrix;
    }
    static int[,] MatrixD(int dim)
    {
        int[,] matrix = new int[dim, dim];
        int numConcentricSquares = (int)Math.Ceiling((dim) / 2.0);
        int j;
        int sideLen = dim;
        int currNum = 0;

        for (int i = 0; i < numConcentricSquares; i++)
        {

            // do left side
            for (j = 0; j < sideLen; j++)
            {
                matrix[i + j, i] = ++currNum;
            }

            // do bottom side
            for (j = 1; j < sideLen - 1; j++)
            {
                matrix[dim - 1 - i, i + j] = ++currNum;
            }

            // do right side
            for (j = sideLen - 1; j > 0; j--)
            {
                matrix[i + j, dim - 1 - i] = ++currNum;
            }

            // do top side
            for (j = sideLen - 1; j > 0; j--)
            {
                matrix[i, i + j] = ++currNum;
            }

            sideLen -= 2;
        }

        return matrix;
    }

    static void PrintMatrix(int [,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}",matrix[rows,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
} 