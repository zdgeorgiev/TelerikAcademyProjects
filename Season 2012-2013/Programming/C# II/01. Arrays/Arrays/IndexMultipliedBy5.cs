﻿using System;

class IndexMultipliedBy5
{
    static void Main()
    {
        int[] myArray = new int[20];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i * 5;
            Console.WriteLine(myArray[i]);
        }
    }
}

//Write a program that allocates array of 20 integers and initializes each 
//element by its index multiplied by 5. Print the obtained array on the console.