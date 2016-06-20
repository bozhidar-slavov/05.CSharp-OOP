namespace InfiniteConvergentSeries
{
    using System;

    public static class InfiniteSeries
    {
        public static double Sum(double firstArg, double secondArg,
            Func<double, double, double> getSum,
            Func<double, double> firstArgBehavior,
            Func<double, double> secondArgBehavior)
        {
            double sum = 0;
            double previousSum;

            do
            {
                previousSum = sum;
                
                sum += getSum(firstArg, secondArg);
                
                firstArg = firstArgBehavior(firstArg);
                secondArg = secondArgBehavior(secondArg);
            }
            while (Math.Abs(sum - previousSum) > 0.0000001);

            return sum;
        }

        public static double Factorial(double y)
        {
            double result = 1;
            for (int i = 1; i <= y; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
