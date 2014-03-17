using System;
using System.Text;

class Digits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        char[] separator = { ' ' };
        string[] line = new string[n];
        for (int i = 0; i < n; i++)
        {
            line = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(line[j]);
            }
        }
        int currentSum = 0;
        for (int i = 0; i < matrix.GetLength(0) - 4; i++)
        {

            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                //do for 1
                if (matrix[i + 2, j] == 1 && 1 == matrix[i + 1, j + 1]
                                    && 1 == matrix[i, j + 2]
                                    && 1 == matrix[i + 1, j + 2]
                                    && 1 == matrix[i + 2, j + 2]
                                    && 1 == matrix[i + 3, j + 2]
                                    && 1 == matrix[i + 4, j + 2])
                {
                    currentSum += 1;
                }
                //do for 2
                else if (matrix[i + 1, j] == 2 && 2 == matrix[i, j + 1]
                                         && 2 == matrix[i + 1, j + 2]
                                         && 2 == matrix[i + 2, j + 2]
                                         && 2 == matrix[i + 3, j + 1]
                                         && 2 == matrix[i + 4, j]
                                        && 2 == matrix[i + 4, j + 1]
                                        && 2 == matrix[i + 4, j + 2])
                {
                    currentSum += 2;
                }
                //do for 3
                else if (matrix[i, j] == 3 && 3 == matrix[i, j + 1]
                                        && 3 == matrix[i, j + 2]
                                        && 3 == matrix[i + 1, j + 2]
                                        && 3 == matrix[i + 2, j + 2]
                                        && 3 == matrix[i + 2, j + 1]
                                        && 3 == matrix[i + 3, j + 2]
                                        && 3 == matrix[i + 4, j + 2]
                                        && 3 == matrix[i + 4, j + 1]
                                        && 3 == matrix[i + 4, j])
                {
                    currentSum += 3;
                }
                //do for 4
                else if (matrix[i, j] == 4 && 4 == matrix[i + 1, j]
                                        && 4 == matrix[i + 2, j]
                                        && 4 == matrix[i + 2, j + 1]
                                        && 4 == matrix[i + 2, j + 2]
                                        && 4 == matrix[i + 1, j + 2]
                                        && 4 == matrix[i, j + 2]
                                        && 4 == matrix[i + 3, j + 2]
                                        && 4 == matrix[i + 4, j + 2])
                {
                    currentSum += 4;
                }
                //do for 5
                else if (matrix[i, j] == 5 && matrix[i, j + 1] == 5 && matrix[i, j + 2] == 5 && matrix[i + 1, j] == 5 && matrix[i + 2, j] == 5 && matrix[i + 2, j + 1] == 5 && matrix[i + 2, j + 2] == 5 && matrix[i + 3, j + 2] == 5
                    && matrix[i + 4, j + 2] == 5 && matrix[i + 4, j + 1] == 5 && matrix[i + 4, j] == 5)
                {
                    currentSum += 5;
                }
                //do for 6
                else if (matrix[i, j] == 6 && matrix[i, j + 1] == 6 && matrix[i, j + 2] == 6 && matrix[i + 1, j] == 6 && matrix[i + 2, j] == 6 && matrix[i + 3, j] == 6 && matrix[i + 4, j] == 6 && matrix[i + 4, j + 1] == 6 &&
                    matrix[i + 4, j + 2] == 6 && matrix[i + 3, j + 2] == 6 && matrix[i + 2, j + 2] == 6 && matrix[i + 2, j + 1] == 6)
                {
                    currentSum += 6;
                }
                //do for 7
                else if (matrix[i, j] == 7 && matrix[i, j + 1] == 7 && matrix[i, j + 2] == 7 && matrix[i + 1, j + 2] == 7 && matrix[i + 2, j + 1] == 7 && matrix[i + 3, j + 1] == 7 && matrix[i + 4, j + 1] == 7)
                {
                    currentSum += 7;
                }
                //do for 8
                else if (matrix[i, j] == 8 && matrix[i, j + 1] == 8 && matrix[i, j + 2] == 8 && matrix[i + 1, j + 2] == 8 && matrix[i + 1, j] == 8 && matrix[i + 2, j + 1] == 8 && matrix[i + 3, j] == 8 && matrix[i + 4, j] == 8
                    && matrix[i + 4, j + 1] == 8 && matrix[i + 4, j + 2] == 8 && matrix[i + 3, j + 2] == 8)
                {
                    currentSum += 8;
                }
                //do for 9
                else if (matrix[i, j] == 9 && matrix[i, j + 1] == 9 && matrix[i, j + 2] == 9 && matrix[i + 1, j] == 9 && matrix[i + 1, j + 2] == 9 && matrix[i + 2, j + 1] == 9 && matrix[i + 2, j + 2] == 9 && matrix[i + 3, j + 2] == 9 && matrix[i + 4, j + 2] == 9 && matrix[i + 4, j + 1] == 9 && matrix[i + 4, j] == 9)
                {
                    currentSum += 9;
                }

            }
        }
        Console.WriteLine(currentSum);
    }
}