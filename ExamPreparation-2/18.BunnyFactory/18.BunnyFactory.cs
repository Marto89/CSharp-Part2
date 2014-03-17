using System;
using System.Text;
using System.Collections.Generic;
using System.Numerics;

class BunnyFactory
{
    static void Main()
    {
        List<int> allCages = new List<int>();
        while (true)
        {
            var currentCage = new StringBuilder(Console.ReadLine());
            if (currentCage.ToString() != "END")
            {
                allCages.Add(int.Parse(currentCage.ToString()));
            }
            else
            {
                break;
            }
        }
        int ithCyckle = 1;
        while (true)
        {
            int sumOfIcages = 0;
            if (ithCyckle > allCages.Count)
            {
                Console.WriteLine(string.Join(" ", allCages));
                break;
            }
            for (int i = 0; i < ithCyckle; i++)
            {
                sumOfIcages += allCages[i];
            }
            if (sumOfIcages <= allCages.Count - ithCyckle)
            {
                BigInteger currentSum = 0;
                BigInteger curremtProduct = 1;
                for (int j = ithCyckle; j < ithCyckle + sumOfIcages; j++)
                {
                    currentSum += allCages[j];
                    curremtProduct *= allCages[j];
                }
                StringBuilder newCages = new StringBuilder();
                newCages.Append(currentSum);
                newCages.Append(curremtProduct);
                for (int i = ithCyckle + sumOfIcages; i < allCages.Count; i++)
                {
                    newCages.Append(allCages[i]);
                }
                allCages = new List<int>();
                for (int i = 0; i < newCages.Length; i++)
                {
                    if (newCages[i] != '0' && newCages[i] != '1')
                    {
                        allCages.Add(newCages[i] - '0');
                    }
                }
            }
            else if (sumOfIcages > allCages.Count - ithCyckle)
            {
                Console.WriteLine(string.Join(" ", allCages));
                break;
            }
            ithCyckle++;
        }
    }
}