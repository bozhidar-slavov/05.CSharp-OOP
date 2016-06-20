namespace Timer
{
    using System;
    using System.Threading;

    public delegate void SimpleDelegate(string param);

    public class Timer
    {
        private int delay;

        public SimpleDelegate SomeMethod { get; set; }

        public Timer(int seconds, SimpleDelegate method)
        {
            this.Delay = seconds;
            this.SomeMethod = method;
        }

        public int Delay
        {
            get
            {
                return this.delay;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid value! Delay cannot be negative or zero!");
                }

                this.delay = value;
            }
        }

        public void Start(uint seconds)
        {
            var end = DateTime.Now.AddMilliseconds(seconds * 1000);

            while (DateTime.Now.Second <= end.Second)
            {
                this.SomeMethod(string.Format("At every {0} seconds im going to appear.", this.delay));
                Thread.Sleep(this.delay * 1000);
            }
        }
    }
}
