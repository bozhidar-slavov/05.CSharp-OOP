namespace GSM.Components
{
    using System;
    using System.Text;

    public class Battery
    {
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery(BatteryType? type, int? hoursIdle, int? hoursTalk)
        {
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery()
            : this(null, null, null)
        {
        }

        public BatteryType? Type { get; set; }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours idle must be positive number!");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours talk must be positive number!");
                }

                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            var batteryInfo = new StringBuilder();

            batteryInfo.AppendFormat("Battery type: {0}", this.Type ?? 0);

            if (this.hoursIdle != null)
            {
                batteryInfo.AppendFormat(", Hours idle: {0}", this.hoursIdle);
            }

            if (this.hoursTalk != null)
            {
                batteryInfo.AppendFormat(", Hours talk: {0}", this.hoursTalk);
            }

            return batteryInfo.ToString();
        }
    }
}
