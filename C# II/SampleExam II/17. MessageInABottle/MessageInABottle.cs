using System;
using System.Collections.Generic;

class Item
{
    public string Letter { get; set; }
    public string Number { get; set; }

    public Item(string letter)
    {
        this.Letter = letter;
    }
}

class MessageInABottle
{
    private static List<string> allSolutions = new List<string>();

    static void Main(string[] args)
    {
        string cipher = Console.ReadLine();
        List<Item> allLetters = GetAllLetters(Console.ReadLine());

        ProccessTheCurrentMessage(allLetters, cipher);
        allSolutions.Sort();

        Console.WriteLine(allSolutions.Count);

        foreach (var solution in allSolutions)
        {
            Console.WriteLine(solution);
        }
    }

    private static void ProccessTheCurrentMessage(List<Item> allLetters, string cipher)
    {
        string currentNumber = string.Empty;
    
        for (int i = 0; i < cipher.Length; i++)
        {
            if (char.IsDigit(cipher[i]))
            {
                currentNumber += cipher[i];
            }
            else
            {
                continue;
            }
    
            for (int currentLetter = 0; currentLetter < allLetters.Count; currentLetter++)
            {
                if (currentNumber == allLetters[currentLetter].Number.ToString())
                {
                    //Add the letter before her number
                    string newCipher = cipher.Insert(cipher.IndexOf(currentNumber),
                        allLetters[currentLetter].Letter);

                    //Remove the current letter number
                    newCipher = newCipher.Remove(newCipher.IndexOf(currentNumber),
                        allLetters[currentLetter].Number.ToString().Length);

                    if (!char.IsDigit(newCipher[newCipher.Length - 1]))
                    {
                        allSolutions.Add(newCipher); 
                    }

                    ProccessTheCurrentMessage(allLetters, newCipher);
                }
            }
        }
    }

    private static List<Item> GetAllLetters(string message)
    {
        List<Item> allLetters = new List<Item>();
        string letterNumber = string.Empty;
        int currentLetter = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] >= 'A' &&
                message[i] <= 'Z')
            {
                allLetters.Add(new Item(message[i].ToString()));
            }
            else
            {
                if (char.IsDigit(message[i]))
                {
                    letterNumber += message[i].ToString();
                }

                if (i + 1 < message.Length && !char.IsDigit(message[i + 1]))
                {
                    allLetters[currentLetter].Number = letterNumber;
                    letterNumber = string.Empty;
                    currentLetter++;
                }
                else if (i + 1 == message.Length)
                {
                    allLetters[currentLetter].Number = letterNumber;
                }
            }
        }

        return allLetters;
    }
}