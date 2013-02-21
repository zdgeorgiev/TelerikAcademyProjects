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
        }
        
        public Battery(int hoursIdle, int hoursTalk)
        {
            this.batteryModel = null;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
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