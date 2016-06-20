namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var list = new List<int>() { 2, -3, 5, 9, 13, 6, 21, 4 };

            Console.WriteLine("Sum: " + list.Sum());
            Console.WriteLine("Product: " + list.Product());
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Average: " + list.Average());
        }
    }
}
