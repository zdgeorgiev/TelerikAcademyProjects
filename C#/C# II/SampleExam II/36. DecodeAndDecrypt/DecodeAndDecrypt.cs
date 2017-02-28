using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecodeAndDecrypt
{
    static void Main(string[] args)
    {
        string encrypted = Console.ReadLine();
        int cypherLenght = GetCypherLenght(encrypted);

        //Remove the last number that shows the lenght of the cypher and decode the message and the cypher
        encrypted = Decode(encrypted.Remove(encrypted.LastIndexOf(cypherLenght.ToString())));

        string cypher = encrypted.Substring(encrypted.Length - cypherLenght);
        encrypted = encrypted.Substring(0, encrypted.Length - cypherLenght);

        string result = Decrypt(encrypted, cypher);
        Console.WriteLine(result);
    }

    private static string Decode(string encrypted)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < encrypted.Length; i++)
        {
            string number = string.Empty;

            while (i < encrypted.Length && char.IsDigit(encrypted[i]))
            {
                number += encrypted[i];
                i++;
            }

            if (number == string.Empty)
            {
                result.Append(encrypted[i]);
            }
            else
            {
                result.Append(new string(encrypted[i], int.Parse(number)));
            }
        }

        return result.ToString();
    }

    private static string Decrypt(string message, string cypher)
    {
        StringBuilder convertedText = new StringBuilder();

        if (message.Length >= cypher.Length)
        {
            int indexOfCypher = 0;

            for (int i = 0; i < message.Length; i++)
            {
                convertedText.Append((char)(65 + ((message[i] - 65) ^ (cypher[indexOfCypher % cypher.Length] - 65))));

                indexOfCypher++;
            }
        }
        else
        {
            while (message.Length > 0)
            {
                int startIndex = 0;
                char encryptedChar = message[startIndex];

                while (startIndex < cypher.Length)
                {
                    encryptedChar = (char)((encryptedChar - 65) ^ (cypher[startIndex] - 65));
                    encryptedChar += (char)65;

                    cypher = cypher.Remove(startIndex, 1);
                    startIndex += message.Length - 1;
                }

                message = message.Remove(0, 1);

                convertedText.Append(encryptedChar);
            }
        }

        return convertedText.ToString();
    }

    private static int GetCypherLenght(string encrypted)
    {
        Stack<string> numbers = new Stack<string>();
        string number = string.Empty;

        for (int i = encrypted.Length - 1; i >= 0; i--)
        {
            if (!char.IsDigit(encrypted[i]))
            {
                break;
            }
            else
            {
                numbers.Push(encrypted[i].ToString());
            }
        }

        while (numbers.Count > 0)
        {
            number += numbers.Pop();
        }

        return int.Parse(number);
    }
}