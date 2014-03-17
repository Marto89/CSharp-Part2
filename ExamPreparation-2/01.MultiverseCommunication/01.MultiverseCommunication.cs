using System;
using System.Text;

class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] array = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        long answer = 0;
        for (int i = 0; i < input.Length; i+=3)
        {           
            for (int j=0;j<array.Length;j++)
            {
                if(input.Substring(i,3)==array[j])
                {
                    answer *= 13;
                    answer += j;
                    break;
                }
            }
        }
        Console.WriteLine(answer);
    }
}