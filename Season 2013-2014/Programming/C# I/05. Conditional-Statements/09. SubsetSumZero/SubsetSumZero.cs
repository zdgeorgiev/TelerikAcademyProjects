using System;

class SubsetSumZero
{
    static void Main()
    {
        int[] userInputNumbers =
        {
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine())
        };

        //If the sum of five elements is zero
        if (userInputNumbers[0] + userInputNumbers[1] + userInputNumbers[2] + userInputNumbers[3] + userInputNumbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} == 0", userInputNumbers[0], userInputNumbers[1], userInputNumbers[2], userInputNumbers[3], userInputNumbers[4]);
            return;
        }

        for (int i = 0; i < userInputNumbers.Length; i++)
        {
            //If the sum of two elements is zero 
            for (int j = 1; j < userInputNumbers.Length; j++)
            {
                if (userInputNumbers[i] + userInputNumbers[j] == 0)
                {
                    Console.WriteLine("{0} + {1} == 0", userInputNumbers[i], userInputNumbers[j]);
                    return;
                }
                //If the sum of three elements is zero
                for (int k = 2; k < userInputNumbers.Length; k++)
                {
                    if (userInputNumbers[i] + userInputNumbers[j] + userInputNumbers[k] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} == 0", userInputNumbers[i], userInputNumbers[j], userInputNumbers[k]);
                        return;
                    }
                    //If the sum of four elements is zero
                    for (int l = 3; l < userInputNumbers.Length; l++)
                    {
                        if (userInputNumbers[i] + userInputNumbers[j] + userInputNumbers[k] + userInputNumbers[l] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} == 0", userInputNumbers[i], userInputNumbers[j], userInputNumbers[k], userInputNumbers[l]);
                            return;
                        }
                    }
                }
            }
        }
    }
}

//We are given 5 integer numbers. Write a program that checks if the
//sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.