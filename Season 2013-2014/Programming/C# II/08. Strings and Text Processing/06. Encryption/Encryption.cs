using System;

class Encryption
{
    static void Main()
    {
        string chifer = "ewq";
        string text = "Write a program that encodes and decodes a string using given";

        int ciferLen = chifer.Length;
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(@"\u{0:x4}", text[i] ^ chifer[i % ciferLen]);
        }
    }
}

//Write a program that encodes and decodes a string using given encryption key 
//(cipher). The key consists of a sequence of characters. The encoding/decoding
//is done by performing XOR (exclusive or) operation over the first letter of the
//string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.