using System;

class MultiplyMethod
{
    public static void MultiplyInt()
    {
        int total = 0;

        for (int i = 0; i < 100; i++)
        {
            total *= i;
        }
    }

    public static void MultiplyLong()
    {
        long total = 0;

        for (long i = 0; i < 100; i++)
        {
            total *= i;
        }
    }

    public static void MultiplyFloat()
    {
        float total = 0;

        for (float i = 0; i < 100; i++)
        {
            total *= i;
        }
    }

    public static void MultiplyDouble()
    {
        double total = 0;

        for (double i = 0; i < 100; i++)
        {
            total *= i;
        }
    }

    public static void MultiplyDecimal()
    {
        decimal total = 0;

        for (decimal i = 0; i < 100; i++)
        {
            total *= i;
        }
    }
}