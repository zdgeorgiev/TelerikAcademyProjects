using System;

class NightmareOnCodeStreet
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine().TrimStart('-');
        int count = 0;
        int sum = 0;

        for (int i = 1; i < number.Length; i += 2)
        {
            int currentNumber;

            if (!char.IsDigit(number[i]))
            {
                continue;
            }

            currentNumber = int.Parse(number[i].ToString());

            sum += currentNumber;
            count++;
        }

        Console.WriteLine(count + " " + sum);
    }
}