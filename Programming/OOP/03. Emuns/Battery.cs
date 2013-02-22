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

    public Battery() 
        : this(null, null, null)
    {
    }

    public Battery(string batteryModel)
        : this(null, null, batteryModel)
    {
    }

    public Battery(int? hoursIdle, int? hoursTalk)
        : this(hoursIdle, hoursTalk, null)
    {
    }

    public Battery(int? hoursIdle, int? hoursTalk, string batteryModel)
    {
        this.batteryModel = batteryModel;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }

    public string BatteryModel
    {
        get { return this.batteryModel; }
        set { this.batteryModel = value; }
    }

    public int? HoursIdle
    {
        get { return this.hoursIdle; }
        set { this.hoursIdle = value; }
    }

    public int? HoursTalk
    {
        get { return this.hoursTalk; }
        set { this.hoursTalk = value; }
    }
}