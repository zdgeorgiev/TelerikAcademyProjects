using System;
using System.Text;

class MaxElementSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        //Fill the array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //Fint the element with max sequence
        int maxSequenceCounter = 1;
        int maxSequenceNumber = int.MinValue;

        for (int j = 0; j < array.Length - 1; j++)
        {
            int currentNumber = array[j];
            int currentSequence = 1;

            for (int k = j + 1; k < array.Length; k++)
            {
                if (currentNumber == array[k])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequenceCounter)
                    {
                        maxSequenceNumber = currentNumber;
                        maxSequenceCounter = currentSequence;
                    }

                    //If the next numbers isnt the same doenst
                    //need to check the other ones because thats not sequence
                    break;
                }
            }
        }

        PrintMaxSequence(maxSequenceCounter, maxSequenceNumber);
    }

    static void PrintMaxSequence(int maxSequenceCounter, int maxSequenceNumber)
    {
        StringBuilder result = new StringBuilder();

        result.Append("{");
        for (int i = 0; i < maxSequenceCounter; i++)
        {
            result.Append(maxSequenceNumber);
            result.Append(", ");
        }
        result.Length -= 2;
        result.Append("}");

        Console.WriteLine("Max sequence = {0}", result.ToString());
    }
}

//Write a program that finds the maximal sequence of equal elements in an array
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.