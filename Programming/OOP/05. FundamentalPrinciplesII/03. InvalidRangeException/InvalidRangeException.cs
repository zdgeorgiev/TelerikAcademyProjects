using System;

public class InvalidRangeException<T> : ApplicationException
    where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    private T start;
    private T end;

    public T Start
    {
        get
        {
            return this.start;
        }
    }

    public T End
    {
        get
        {
            return this.end;
        }
    }

    public InvalidRangeException(string msg)
        : base(msg)
    {
    }

    public InvalidRangeException(string msg, Exception innerEx)
        : base(msg, innerEx)
    {
    }

    public InvalidRangeException(string msg, T start, T end) : this(msg, null, start, end)
    {
    }

    public InvalidRangeException(string msg, Exception innerEx, T start, T end)
        : base(msg, innerEx)
    {
        this.start = start;
        this.end = end;
    }
}

//Define a class InvalidRangeException<T> that holds information
//    about an error condition related to invalid range.
//        It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int>
//    and InvalidRangeException<DateTime> by entering numbers in the range [1..100]
//    and dates in the range [1.1.1980 … 31.12.2013].
