using System;

class DrunkenNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int vladkoBeers = 0;
        int mitkoBeers = 0;


        for (int i = 0; i < n; i++)
        {

            string s = Console.ReadLine();
            string total = string.Empty;

            //if (n == 1)
            //{
            //    Console.WriteLine("No " + (mitkoBeers + vladkoBeers));
            //    return;
            //}

            if (s.Contains("."))
            {
                string[] arr = s.Split('.');

                total += arr[0] + arr[1];
            }
            else
            {
                total = s;
            }

            decimal inputNumber = Math.Abs(decimal.Parse(total));
            string numberInput = inputNumber.ToString();

            if (numberInput.Length % 2 == 0)
            {
                string leftPart = numberInput.Substring(0, numberInput.Length / 2);
                string rightPart = numberInput.Substring(numberInput.Length / 2, numberInput.Length - numberInput.Length / 2);
                int leftBeersString = int.Parse(leftPart);
                int rightBeersString = int.Parse(rightPart);
                int beersLeft = 0;
                int beersRight = 0;

                while (leftBeersString > 0)
                {
                    beersLeft += leftBeersString % 10;
                    leftBeersString /= 10;
                }

                while (rightBeersString > 0)
                {
                    beersRight += rightBeersString % 10;
                    rightBeersString /= 10;
                }

                vladkoBeers += beersLeft;
                mitkoBeers += beersRight;
            }
            else
            {
                string leftPart = numberInput.Substring(0, numberInput.Length / 2 + 1);
                string rightPart = numberInput.Substring(numberInput.Length / 2, numberInput.Length - numberInput.Length / 2);

                int leftBeersString = int.Parse(leftPart);
                int rightBeersString = int.Parse(rightPart);
                int beersLeft = 0;
                int beersRight = 0;

                while (leftBeersString > 0)
                {
                    beersLeft += leftBeersString % 10;
                    leftBeersString /= 10;
                }

                while (rightBeersString > 0)
                {
                    beersRight += rightBeersString % 10;
                    rightBeersString /= 10;
                }

                vladkoBeers += beersLeft;
                mitkoBeers += beersRight;
            }
        }

        if (vladkoBeers == mitkoBeers)
        {
            Console.WriteLine("No " + (mitkoBeers + vladkoBeers));
        }
        else if (vladkoBeers > mitkoBeers)
        {
            Console.WriteLine("M " + (vladkoBeers - mitkoBeers));
        }
        else
        {
            Console.WriteLine("V " + (mitkoBeers - vladkoBeers));
        }
    }
}