using System;

namespace Constructors
{
    class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;

        public Battery()
        {
            this.batteryModel = null;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
    }
}