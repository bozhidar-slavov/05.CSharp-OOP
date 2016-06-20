namespace Events
{
    using System;
    using System.Threading;

    public class Timer : EventArgs
    {
        public event EventHandler RaiseCustomEvent;

        private static int delay;

        public Timer(int seconds)
        {
            Delay = seconds;
        }

        public static int Delay
        {
            get
            {
                return delay;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Delay can't be zero or negative.");
                }

                delay = value;
            }
        }

        protected void OnRaiseCustomEvent()
        {
            var handler = RaiseCustomEvent;

            if (handler != null)
            {
                handler(this, null);
            }
        }

        public void Start(uint seconds)
        {
            var end = DateTime.Now.AddMilliseconds(seconds * 1000);

            while (DateTime.Now.Second <= end.Second)
            {
                OnRaiseCustomEvent();

                Thread.Sleep(Delay * 1000);
            }
        }
    }
}
