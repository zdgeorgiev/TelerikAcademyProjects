using System;

class Carpets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;


        for (int i = 0; i < n / 2; i++)
        {
            int elementCount = 1;

            while (elementCount <= n)
            {
                if ((elementCount <= n / 2 - i - 1) || (elementCount > n / 2 + i + 1))
                {
                    Console.Write('.');
                    elementCount++;
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            elementCount++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementCount++;
                        }
                    }
                    for (int j = i; j >= 0; j--)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            elementCount++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementCount++;
                        }
                    }
                }
            }

            elementCount++;
            Console.WriteLine();
        }

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            int elementCount = 1;

            while (elementCount <= n)
            {
                if ((elementCount <= n / 2 - i - 1) || (elementCount > n / 2 + i + 1))
                {
                    Console.Write('.');
                    elementCount++;
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            elementCount++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementCount++;
                        }
                    }
                    for (int j = i; j >= 0; j--)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            elementCount++;
                        }
                        else
                        {
                            Console.Write(" ");
                            elementCount++;
                        }
                    }
                }
            }

            elementCount++;
            Console.WriteLine();
        }
    }
}