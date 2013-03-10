using System;
using System.Threading;

public delegate void Ticker(string text);

public class Timer
{
    public static void StartTimer(string str)
    {
        Thread.Sleep(3000);
        Console.WriteLine(str);
    }
}