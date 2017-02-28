using System;

class DivideMethod
{
    public static void DivideInt()
    {
        int total = 50000;

        for (int i = 1; i <= 100; i++)
        {
            total /= i;
        }
    }

    public static void DivideLong()
    {
        long total = 50000;

        for (long i = 1; i <= 100; i++)
        {
            total /= i;
        }
    }

    public static void DivideFloat()
    {
        float total = 50000;

        for (float i = 1; i <= 100; i++)
        {
            total /= i;
        }
    }

    public static void DivideDouble()
    {
        double total = 50000;

        for (double i = 1; i <= 100; i++)
        {
            total /= i;
        }
    }

    public static void DivideDecimal()
    {
        decimal total = 50000M;

        for (decimal i = 1; i <= 100; i++)
        {
            total /= i;
        }
    }
}