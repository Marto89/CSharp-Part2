using System;

class PatternsProgram
{
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int [,]matrix=new int[n,n];

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int  j= 0;  j< n; j++)
            {
                matrix[i, j]=int.Parse(line[j]);
            }
        }
        bool flag = false;
        int maxSum = 0;
        for (int i = 0; i < n-2; i++)
        {
            for (int j = 0; j < n-4; j++)
            {
                int currentSum=0;
                if (matrix[i, j] == matrix[i, j + 1] - 1 && matrix[i, j + 1] == matrix[i, j + 2] - 1 && matrix[i, j + 2] == matrix[i + 1, j + 2] - 1 && matrix[i + 1, j + 2] == matrix[i + 2, j + 2] - 1 && matrix[i + 2, j + 2] == matrix[i + 2, j + 3] - 1 && matrix[i + 2, j + 3]==matrix[i+2,j+4]-1)
                {
                    flag = true;
                    int currentElement=matrix[i,j];
                    currentSum = currentElement;
                    for (int k = 0; k < 6; k++)
                    {
                        currentElement++;
                        currentSum += currentElement;
                    }
                }
                if(currentSum>maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        if(flag)
        {
            Console.WriteLine("YES {0}",maxSum);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                maxSum += matrix[i, i];
            }
            Console.WriteLine("NO {0}",maxSum);
        }
    }
}