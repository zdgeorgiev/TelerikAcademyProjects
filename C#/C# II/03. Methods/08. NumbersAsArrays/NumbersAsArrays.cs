using System;
using System.Text;
using System.Numerics;

class NumbersAsArrays
{
    public static BigInteger NumberAdder(int[] firstNumber, int[] secondNumber)
    {
        StringBuilder firstNumberString = new StringBuilder();

        for (int i = 0; i < firstNumber.Length; i++)
        {
            firstNumberString.Append(firstNumber[i]);
        }
        
        StringBuilder secondNumberString = new StringBuilder();

        for (int i = 0; i < secondNumber.Length; i++)
        {
            secondNumberString.Append(secondNumber[i]);
        }

        BigInteger firstNumb = BigInteger.Parse(firstNumberString.ToString());
        BigInteger secondNumb = BigInteger.Parse(secondNumberString.ToString());

        BigInteger result = firstNumb + secondNumb;

        return result;
    }

    public static void Main()
    {
        int[] firstArray = new int[] { 4561, 213253, 45654, 35434 };
        int[] secondArray = new int[] { 2, 64564, 414, 555, 1, 654 };

        Console.WriteLine(NumberAdder(firstArray, secondArray));
    }
}

//Write a method that adds two positive integer numbers represented as 
//arrays of digits (each array element arr[i] contains a digit; the
//last digit is kept in arr[0]). Each of the numbers that will be
//added could have up to 10 000 digits.