using System;

public enum BatteryType
{
    LiIon, NiMH, NiCd
}

class Battery
{
    private string batteryModel;
    private int? hoursIdle;
    private int? hoursTalk;
    private BatteryType batteryType;

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
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.batteryModel = batteryModel;
        this.batteryType = batteryType;
    }

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
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("BatteryModel cannot be empty.");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException("BatteryModel is too short! It should be at least 2 letters.");
            }
            else if (value.Length > 50)
            {
                throw new ArgumentException("BatteryModel is too long! It should be less than 50 letters.");
            }
            this.batteryModel = value; 
        }
    }

    public int? HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value < 0 || value == null)
            {
                throw new ArgumentException("HoursIdle cannot be smaller than 0.");
            }
            this.hoursIdle = value; 
        }
    }

    public int? HoursTalk
    {
        get { return this.hoursTalk; }
        set 
        {
            if (value < 0 || value == null)
            {
                throw new ArgumentException("HoursTalk cannot be smaller than 0.");
            }
            this.hoursTalk = value; 
        }
    }
}