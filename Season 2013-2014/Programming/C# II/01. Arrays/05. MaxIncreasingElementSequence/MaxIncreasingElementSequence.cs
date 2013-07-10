using System;
using System.Text;

class MaxIncreasingElementSequence
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
        int maxIncreasingSequenceCounter = 1;
        int firstSequenceNumber = int.MinValue;
        int nextNumber = 1;

        for (int j = 0; j < array.Length - 1; j++)
        {
            int currentNumber = array[j];
            int currentSequence = 1;

            for (int k = j + 1; k < array.Length; k++)
            {
                if (currentNumber == array[k] - nextNumber)
                {
                    currentSequence++;
                    //To check if the next number is bigger with 1 from
                    //first one we should increase the next number also with 1
                    nextNumber++;
                }
                else
                {
                    //If the next numbers isnt the same doenst
                    //need to check the other ones because thats not sequence
                    break;

                }
            }

            if (currentSequence > maxIncreasingSequenceCounter)
            {
                firstSequenceNumber = currentNumber;
                maxIncreasingSequenceCounter = currentSequence;
            }
        }

        PrintMaxIncreasingSequence(maxIncreasingSequenceCounter, firstSequenceNumber);
    }

    static void PrintMaxIncreasingSequence(int maxIncreasingSequenceCounter, int firstSequenceNumber)
    {
        StringBuilder result = new StringBuilder();

        result.Append("{");
        for (int i = 0; i < maxIncreasingSequenceCounter; i++)
        {
            //Use the first founded number and increase it
            //with 1 for each increasing sequence coutner
            result.Append(firstSequenceNumber + i);
            result.Append(", ");
        }
        result.Length -= 2;
        result.Append("}");

        Console.WriteLine("Max increasing sequence = {0}", result.ToString());
    }
}

//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.