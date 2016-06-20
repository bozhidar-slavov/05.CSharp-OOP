namespace Events
{
    public class Startup
    {
        public static void Main()
        {
            var publish = new Timer(seconds: 1);

            var someone = new Subscriber("Someone", publish);
            
            publish.Start(seconds: 5);
        }
    }
}
