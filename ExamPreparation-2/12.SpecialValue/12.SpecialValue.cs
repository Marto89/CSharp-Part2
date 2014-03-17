using System;

class SpecialValue
{
    static int[][] ConvertToIntArray(int[][] row, int n)
    {
        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            jaggedArray[i] = new int[currentRow.Length];
            for (int j = 0; j < currentRow.Length; j++)
            {
                jaggedArray[i][j] = int.Parse(currentRow[j]);
            }
        }
        return jaggedArray;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];
        int maxLength = 0;
        jaggedArray = ConvertToIntArray(jaggedArray, n);
        for (int i = 0; i < n; i++)
        {
            if (maxLength < jaggedArray[i].Length)
            {
                maxLength = jaggedArray[i].Length;
            }
        }
        int maxSum = 0;
        for (int col = 0; col < jaggedArray[0].Length; col++)
        {
            int currentSum = 0;
            int currentRow = 0;
            int item = jaggedArray[currentRow][col];
            int path = 1;
            bool[,] jaggedBoolArray = new bool[n, maxLength];
            if (item >= 0)
            {
                do
                {
                    jaggedBoolArray[currentRow % n, col] = true;
                    currentRow++;
                    item = jaggedArray[currentRow % n][item];
                    path++;
                    if (item < 0)
                    {
                        break;
                    }
                    jaggedBoolArray[currentRow % n, item] = true;
                } while (jaggedBoolArray[(currentRow + 1) % n, item] != true);
                currentSum = path + Math.Abs(item);
            }
            else
            {
                currentSum = path + Math.Abs(item);
            }
            if (maxSum < currentSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine(maxSum);
    }
}