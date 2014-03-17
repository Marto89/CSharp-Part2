using System;
using System.Text;

class TRES4Numbers
{
    static void Main()
    {
        ulong numberInDecimal = ulong.Parse(Console.ReadLine());
        string[] allDigitsInTRESNUM4 = {"LON+","VK-","*ACAD","^MIM","ERIK|","SEY&","EMY>>","/TEL","<<DON"};

        var answer=new StringBuilder();
        while (numberInDecimal!=0)
        {
            answer.Insert(0,allDigitsInTRESNUM4[numberInDecimal%9]);
            numberInDecimal /= 9;
        }
        Console.WriteLine(answer);
    }
}