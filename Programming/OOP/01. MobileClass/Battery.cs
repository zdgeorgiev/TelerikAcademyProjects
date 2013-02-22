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