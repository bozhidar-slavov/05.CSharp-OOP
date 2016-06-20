namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        private static void CheckCollection<T>(IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("Empty collection!");
            }
        }

        public static T Sum<T> (this IEnumerable<T> elements)
            where T : IComparable
        {
            CheckCollection(elements);

            dynamic sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }

            return sum;
        }

        public static T Product<T> (this IEnumerable<T> elements)
            where T : IComparable
        {
            CheckCollection(elements);

            dynamic product = 1;
            foreach (var element in elements)
            {
                product *= element;
            }

            return product;
        }

        public static T Min<T> (this IEnumerable<T> elements)
            where T : IComparable
        {
            CheckCollection(elements);

            T min = elements.First();
            foreach (var element in elements)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T> (this IEnumerable<T> elements)
            where T : IComparable
        {
            CheckCollection(elements);

            T max = elements.First();
            foreach (var element in elements)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }

            return max;
        }

        public static double Average<T> (this IEnumerable<T> elements)
            where T : IComparable
        {
            double average = 0.0;

            average = (dynamic)elements.Sum() / elements.Count();

            return average;
        }
    }
}
