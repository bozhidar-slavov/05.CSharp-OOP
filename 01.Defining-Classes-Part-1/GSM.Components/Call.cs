namespace GSM.Components
{
    using System;
    using System.Text;

    public class Call
    {
        public const decimal PricePerMinute = 0.37M;

        public string Date { get; set; }
        
        public string Time { get; set; }

        public string DialedPhone { get; set; }

        public int DurationInSeconds { get; set; }

        public Call(DateTime dateTime, string phone, int duration)
        {
            this.Date = dateTime.Date.ToString();
            this.Time = dateTime.TimeOfDay.ToString();
            this.DialedPhone = phone;
            this.DurationInSeconds = duration;
        }

        public override string ToString()
        {
            var callInfo = new StringBuilder();

            callInfo.AppendFormat("Date: {0}", this.Date);
            callInfo.AppendFormat(", Time: {0}", this.Time);
            callInfo.AppendFormat(", Dialed phone: {0}", this.DialedPhone);
            callInfo.AppendFormat(", Duration in seconds {0}", this.DurationInSeconds);

            return callInfo.ToString();
        }
    }
}
