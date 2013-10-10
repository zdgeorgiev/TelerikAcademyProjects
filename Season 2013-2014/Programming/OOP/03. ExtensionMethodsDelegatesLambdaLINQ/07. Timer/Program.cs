using System;

class Program
{
    static void Main()
    {
        Ticker timer = new Ticker(Timer.StartTimer);

        while (true)
        {
            timer("back from the death like Makaveli");
        }
    }
}