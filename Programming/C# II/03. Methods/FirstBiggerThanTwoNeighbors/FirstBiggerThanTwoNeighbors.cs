using System;

    class FirstBiggerThanTwoNeighbors
    {
        static int BiggerThanTwoNeighbors(int[] array)
        {
            int FirstNumber = -1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    FirstNumber = array[i];
                    break;
                }
            }

            return FirstNumber;
        }

        static void Main()
        {
            int[] myArr = new int[] { 1, 1, 1, 2, 5, 7, 911, 1, 7, 1, 9, 7, 2, 1, 1, 77, 1 };

            foreach (var numb in myArr)
            {
                Console.Write(numb + " ");
            }
            Console.WriteLine();

            Console.WriteLine("First Number higer than his neighbors is {0}", BiggerThanTwoNeighbors(myArr));
        }
    }

//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.
