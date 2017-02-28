using System;

public class Call
{
    private const int DialedPhoneLenght = 10;

    private DateTime date;
    private string dialedPhone;
    private ulong duration;

    public Call(DateTime date, string dialedPhone, ulong duration)
    {
        this.Date = date;
        this.DialedPhone = dialedPhone;
        this.Duration = duration;
    }

    public DateTime Date
    {
        get
        {
            return this.date;
        }
        set
        {
            this.date = value;
        }
    }

    public string DialedPhone
    {
        get
        {
            return this.dialedPhone;
        }
        set
        {
            if (value.Length != DialedPhoneLenght)
            {
                throw new ArgumentException("Invalid phone number");
            }
            
            this.dialedPhone = value;
        }
    }

    public ulong Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid phone talk duration");
            }

            this.duration = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Date: {0}, From Number: {1}, Duration: {2}", this.Date, this.dialedPhone, this.Duration);
    }
}