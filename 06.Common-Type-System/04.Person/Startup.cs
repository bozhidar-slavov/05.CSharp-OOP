namespace Person
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstPerson = new Person("Bugi Barabata", 55);
            var secondPerson = new Person("Mitio Pishtova");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
