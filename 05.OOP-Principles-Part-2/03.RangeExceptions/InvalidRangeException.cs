namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(T start, T end)
            : base(string.Format("Out of range [{0}...{1}]", start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
