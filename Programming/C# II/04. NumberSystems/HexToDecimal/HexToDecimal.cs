using System;

    class HexToDecimal
    {
        static void Main()
        {
            string Binary = Convert.ToString(Console.ReadLine());
            int decimalNumber = 0;

            for (int i = 0; i < Binary.Length; i++)
            {
                if (Binary[Binary.Length - i - 1] == '0')
                {
                    continue;
                }
                decimalNumber += (int)Math.Pow(16, i);
            }

            Console.WriteLine("{0} - {1}", Binary, decimalNumber);
        }
    }

    //Write a program to convert hexadecimal numbers to their decimal representation.