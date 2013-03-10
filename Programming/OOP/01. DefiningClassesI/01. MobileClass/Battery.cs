using System;

class Battery
{
    private string batteryModel;
    private int? hoursIdle;
    private int? hoursTalk;
    private BatteryType batteryType;

    //Constructors
    public Battery() 
        : this(null, null, null, 0)
    {
    }

    public Battery(string batteryModel)
        : this(null, null, batteryModel, 0)
    {
    }

    public Battery(int? hoursIdle, int? hoursTalk)
        : this(hoursIdle, hoursTalk, null , 0)
    {
    }

    public Battery(int? hoursIdle, int? hoursTalk, string batteryModel)
        : this(hoursIdle, hoursTalk, batteryModel, 0)
    {
    }

    public Battery(int? hoursIdle, int? hoursTalk, string batteryModel, BatteryType batteryType)
    {
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.BatteryModel = batteryModel;
        this.BatteryType = batteryType;
    }

    //Properties
    public BatteryType BatteryType
    {
        get { return this.batteryType; }
        set { this.batteryType = value; }
    }

    public string BatteryModel
    {
        get { return this.batteryModel; }
        set
        {
            if (value == null || value.Length > 2)
            {
                this.batteryModel = value;
            }
            else
            {
                throw new ArgumentException("BatteryModel name should be atleast 3 chars.");
            }
        }
    }

    public int? HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value == null || value >= 0)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException("HoursTalk annot be smallar than 0");
            }
        }
    }

    public int? HoursTalk
    {
        get { return this.hoursTalk; }
        set 
        {
            if (value == null || value >= 0)
            {
                this.hoursTalk = value; 
            }
            else
            {
                throw new ArgumentException("HoursTalk cannot be smallar than 0");
            }
        }
    }
}