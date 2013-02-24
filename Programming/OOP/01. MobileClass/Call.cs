using System;

class Call
{
    private DateTime dateAndTime;
    private decimal dialedPhoneNumber;
    private int duration;

    //Constructors
    public Call(DateTime dateAndTime, decimal dialedPhoneNumber, int duration)
    {
        this.DateAndTime = dateAndTime;
        this.DialedPhoneNumber = dialedPhoneNumber;
        this.Duration = duration;
    }

    //Methods
    public override string ToString()
    {
        return string.Format("Date - {0}, DialedPhone - {1}, Duratrion - {2} seconds",
            this.dateAndTime, this.dialedPhoneNumber, this.duration);
    }

    //Properties
    public DateTime DateAndTime
    {
        get { return this.dateAndTime; }
        set { this.dateAndTime = value; }
    }

    public decimal DialedPhoneNumber
    {
        get { return this.dialedPhoneNumber; }
        set { this.dialedPhoneNumber = value; }
    }

    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }
}
