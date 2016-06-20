namespace Events
{
    using System;

    public class Subscriber
    {
        private string id;

        public Subscriber(string ID, Timer pub)
        {
            this.id = ID;

            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Time is {0} -> At every {1} seconds i'm going to appear.",
                    DateTime.Now.ToLongTimeString(), Timer.Delay);
        }
    }
}
