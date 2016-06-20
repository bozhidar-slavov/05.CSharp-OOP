namespace InfiniteConvergentSeries
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            double testOne = InfiniteSeries.Sum(1, 1, (x, y) => x / y, x => x, y => y * 2);

            Console.WriteLine(testOne);

            double testTwo = InfiniteSeries.Sum(1, 1, (x, y) => x / InfiniteSeries.Factorial(y), x => x, y => y + 1);

            Console.WriteLine(testTwo);

            double testThree = InfiniteSeries.Sum(2, 0, (x, y) => y % 2 == 0 && y != 0  ? -Math.Pow(x, y) : Math.Pow(x, y), x => x, y => y - 1);

            Console.WriteLine(testThree);
        }
    }
}
