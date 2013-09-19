using System;
using System.Text;

public class Battery
{
    private BatteryModel batteryModel;
    private ulong? hoursIdle;
    private ulong? hoursTalk;

    public Battery(BatteryModel batteryModel, ulong? hoursTalk)
        : this(batteryModel, null, hoursTalk)
    {
    }

    public Battery(BatteryModel batteryModel, ulong? hoursIdle = null, ulong? hoursTalk = null)
    {
        this.BatteryModel = batteryModel;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    public BatteryModel BatteryModel
    {
        get
        {
            return this.batteryModel;
        }
        set
        {
            this.batteryModel = value;
        }
    }

    public ulong? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours idle cannot be less than 0.");
            }

            this.hoursIdle = value;
        }
    }

    public ulong? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours talk cannot be less than 0.");
            }

            this.hoursTalk = value;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        output.Append(string.Format("(Model - {0}", this.BatteryModel));

        if (this.HoursIdle != null)
        {
            output.Append(string.Format(", HoursIdle - {0}", this.HoursIdle));
        }

        if (this.HoursTalk != null)
        {
            output.Append(string.Format(", HoursTalk - {0}", this.HoursTalk));
        }

        output.AppendLine(")");
        output.Length -= 2;

        return output.ToString();
    }
}