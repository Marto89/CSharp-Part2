//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

using System;
using System.IO;

class MaxSumInMatrix
{
     
    static void Main()
    {
        int nNumbers = int.Parse(Console.ReadLine());
        int[,] finalArray = new int[2, 2];
        int maxSum = int.MinValue; 
        StreamWriter writer = new StreamWriter("matrix.txt");
        using(writer)
        {
            for (int i = 0; i < nNumbers; i++)
            {
                writer.WriteLine(Console.ReadLine());
            }
        }

        StreamReader reader = new StreamReader("matrix.txt");
        using(reader)
        {           
                       
            int [,] inputArray=new int[nNumbers,nNumbers];
            for (int rows = 0; rows < inputArray.GetLength(0); rows++)
            {
                string currentRow = string.Empty;
                currentRow = reader.ReadLine();
                string[] stringArray;
                stringArray = currentRow.Split(' ');
                for (int cols = 0; cols < inputArray.GetLength(1); cols++)
                {
                    inputArray[rows, cols] = int.Parse(stringArray[cols]);
                }
            }          
            for (int row = 0; row <nNumbers-1; row++)
            {
                
                for (int col = 0; col < nNumbers-1; col++)
                {
                    int currentSum =0;
                    currentSum += inputArray[row, col] + inputArray[row, col+1] + inputArray[row+1, col] + inputArray[row+1, col+1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        finalArray[0, 0] = inputArray[row, col];
                        finalArray[0, 1] = inputArray[row, col + 1];
                        finalArray[1, 0] = inputArray[row+1, col];
                        finalArray[1, 1] = inputArray[row+1, col + 1];
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
        StreamWriter finalWriter=new StreamWriter("finalAnswer.txt");
        using (finalWriter)
        {
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    finalWriter.Write(finalArray[row,col]);
                    finalWriter.Write(" ");
                }
                finalWriter.WriteLine();
            }
            finalWriter.WriteLine(maxSum);
        }
    }
}