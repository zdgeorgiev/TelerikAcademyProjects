using System;
using System.Collections.Generic;
using System.Text;

class EncodeAndEncrypt
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();

        StringBuilder convertedText = Encrypt(message, cypher).Append(cypher);
        StringBuilder convertedString = Encode(convertedText).Append(cypher.Length);

        Console.WriteLine(convertedString);
    }

    private static StringBuilder Encode(StringBuilder convertedText)
    {
        Dictionary<char, int> allLetters = new Dictionary<char, int>();
        StringBuilder convertedString = new StringBuilder();

        for (int i = 0; i < convertedText.Length; i++)
        {
            char currentLetter = convertedText[i];
            int counter = 1;

            for (int j = i + 1; j < convertedText.Length; j++)
            {
                if (currentLetter != convertedText[j])
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }

            string convertedLetter = string.Empty;

            if (allLetters.ContainsKey(currentLetter))
            {
                if (allLetters[currentLetter] < counter)
                {
                    allLetters[currentLetter] = counter;
                    convertedLetter = string.Format("{0}{1}", counter, currentLetter);
                }
                else
                {
                    if (counter > 2)
                    {
                        allLetters[currentLetter] = counter;
                        convertedLetter = new string(currentLetter, counter);
                    }
                    else
                    {
                        convertedLetter = new string(currentLetter, counter);
                    }
                }
            }
            else
            {
                if (counter > 2)
                {
                    allLetters.Add(currentLetter, counter);
                    convertedLetter = string.Format("{0}{1}", counter, currentLetter);
                }
                else
                {
                    convertedLetter = new string(currentLetter, counter);
                }
            }

            convertedString.Append(convertedLetter);

            i += counter - 1;
        }

        return convertedString;
    }

    private static StringBuilder Encrypt(string message, string cypher)
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

        return convertedText;
    }
}