using System;

public class InvalidRangeException<T> : ApplicationException
    where T : IComparable, IFormattable
{
    public int Start { get; private set; }
    public int End { get; private set; }

    public InvalidRangeException(string msg, int start, int end)
        : base(msg)
    {
    }

    public InvalidRangeException(string msg, int start, int end, Exception ex)
        : base(msg, ex)
    {
        this.Start = start;
        this.End = end;
    }
}