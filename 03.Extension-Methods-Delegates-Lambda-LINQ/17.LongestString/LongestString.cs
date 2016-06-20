namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Main()
        {
            string[] array = { "Swimming", "Football", "Volleyball", "Basketball", "MixedMartialArts", "Golf" };

            var longestString = array.OrderByDescending(x => x.Length).First();

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine();
            Console.WriteLine("Longest string from array: {0}, Length = {1}", longestString, longestString.Length);
        }
    }
}
