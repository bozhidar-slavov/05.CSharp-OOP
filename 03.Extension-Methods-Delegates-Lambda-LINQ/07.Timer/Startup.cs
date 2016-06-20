namespace Timer
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var timer = new Timer(2, Print);
            timer.Start(10);
        }

        public static void Print(string param)
        {
            Console.WriteLine("Time is {0} -> {1}", DateTime.Now.ToLongTimeString(), param);
        }
    }
}
