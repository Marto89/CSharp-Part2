using System;
using System.Text;
class EncodeAndEncrypt
{
    static void Main()
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();

        StringBuilder encryptedMessage=new StringBuilder(message);
        for (int i = 0; i < Math.Max(message.Length,cypher.Length); i++)
        {
            encryptedMessage[i%encryptedMessage.Length] = (char)((((encryptedMessage[i%encryptedMessage.Length] - 'A') ^ (cypher[i % cypher.Length] - 'A')) + 'A'));
        }
        encryptedMessage.Append(cypher);

        StringBuilder encodedMessage = new StringBuilder();
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            int repeatedLetter = 1;
            while (i < encryptedMessage.Length-1 && encryptedMessage[i] == encryptedMessage[i + 1]) 
            {
                repeatedLetter++;
                i++;
            }
            if(repeatedLetter>2)
            {
                encodedMessage.Append(repeatedLetter);
                encodedMessage.Append(encryptedMessage[i]);
            }
            else
            {
                encodedMessage.Append(encryptedMessage[i],repeatedLetter);
            }
        }
        encodedMessage.Append(cypher.Length);
        Console.WriteLine(encodedMessage);
    }
}