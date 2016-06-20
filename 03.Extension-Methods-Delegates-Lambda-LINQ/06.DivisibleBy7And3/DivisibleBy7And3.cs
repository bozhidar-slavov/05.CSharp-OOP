namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class DivisibleBy7And3
    {
        public static void Main()
        {
            int[] array = { 3, 7, 18, 21, 35, 42, 49, 63, 70, 84 };
            Console.WriteLine(string.Join(" ", array));

            var divisibleBySevenAndFive = array.Where(x => x % 21 == 0);

            Console.WriteLine("Numbers divisible by seven and five:");
            foreach (var number in divisibleBySevenAndFive)
            {
                Console.WriteLine(number);
            }
        }
    }
}
