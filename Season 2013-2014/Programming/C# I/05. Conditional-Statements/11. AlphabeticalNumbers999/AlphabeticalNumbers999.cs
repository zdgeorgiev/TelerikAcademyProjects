using System;

class AlphabeticalNumbers999
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number between [1..999] - ");
        int userNumber = int.Parse(Console.ReadLine());
        string numberInWords = string.Empty;

        if (userNumber > 100)
        {
            int firstDigit = userNumber / 100 % 10;
            int secondDigits = userNumber % 100;

            numberInWords += NumberInWords(firstDigit) + " " + "hundred";

            if (secondDigits != 0)
            {
                if (secondDigits <= 19)
                {
                    numberInWords += " " + "and" + " " + NumberInWords(secondDigits);
                }
                else
                {
                    int leftNumber = secondDigits / 10 * 10;
                    int rightNumber = secondDigits % 10;

                    if (rightNumber != 0)
                    {
                        numberInWords += " " + NumberInWords(leftNumber) + " " + NumberInWords(rightNumber);
                    }
                    else
                    {
                        numberInWords += " and " + NumberInWords(leftNumber);
                    }
                }
            }
        }
        else if (userNumber < 100 && userNumber >= 19)
        {
            int leftNumber = userNumber % 100 / 10 * 10;
            int rightNumber = userNumber % 100 % 10;

            if (rightNumber != 0)
            {
                numberInWords += NumberInWords(leftNumber) + " " + NumberInWords(rightNumber);
            }
            else
            {
                numberInWords += NumberInWords(leftNumber);
            }
        }
        else if (userNumber <= 19)
        {
            numberInWords += NumberInWords(userNumber);
        }
        else
        {
            numberInWords += NumberInWords(userNumber);
        }

        Console.WriteLine(UppercaseFirst(numberInWords));
    }

    private static string NumberInWords(int number)
    {
        string numberAsString = string.Empty;

        switch (number)
        {
            case 1: numberAsString = "one"; break;
            case 2: numberAsString = "two"; break;
            case 3: numberAsString = "three"; break;
            case 4: numberAsString = "four"; break;
            case 5: numberAsString = "five"; break;
            case 6: numberAsString = "six"; break;
            case 7: numberAsString = "seven"; break;
            case 8: numberAsString = "eight"; break;
            case 9: numberAsString = "nine"; break;
            case 10: numberAsString = "ten"; break;
            case 11: numberAsString = "eleven"; break;
            case 12: numberAsString = "twelve"; break;
            case 13: numberAsString = "thirteen"; break;
            case 14: numberAsString = "fourteen"; break;
            case 15: numberAsString = "fifteen"; break;
            case 16: numberAsString = "sixteen"; break;
            case 17: numberAsString = "seventeen"; break;
            case 18: numberAsString = "eighteen"; break;
            case 19: numberAsString = "nineteen"; break;
            case 20: numberAsString = "twenty"; break;
            case 30: numberAsString = "thirty"; break;
            case 40: numberAsString = "forty"; break;
            case 50: numberAsString = "fifty"; break;
            case 60: numberAsString = "sixty"; break;
            case 70: numberAsString = "seventy"; break;
            case 80: numberAsString = "eighty"; break;
            case 90: numberAsString = "ninety"; break;
            default:
                throw new ArgumentException("Invalid number!");
        }

        return numberAsString;
    }

    static string UppercaseFirst(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}

//* Write a program that converts a number in the range [0...999] 
//to a text corresponding to its English pronunciation. Examples:
//    0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"