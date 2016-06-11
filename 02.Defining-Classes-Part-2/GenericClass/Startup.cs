namespace GenericClass
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var list = new GenericList<int>(3);

            list.Add(-5);
            list.Add(10);
            list.Add(15);
            list.InsertAtGivenPosition(3, 20);
            list.RemoveByIndex(3);
            // list.Clear();

            Console.WriteLine(list);
            Console.WriteLine("First index: " + list[1]);
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());
        }
    }
}
