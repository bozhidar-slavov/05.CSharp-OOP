namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            if (startIndex >= input.Length || startIndex < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }

            if (length < 0)
            {
                throw new ArgumentException("Length must be greater than zero!");
            }

            if (startIndex + length >= input.Length)
            {
                throw new ArgumentException("Length is too big!");
            }

            var result = new StringBuilder();
            for (int i = startIndex; i < length + startIndex; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            if (index >= input.Length || index < 0)
            {
                throw new ArgumentException("Invalid index range!");
            }

            var result = new StringBuilder();
            for (int i = index; i < input.Length; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }
    }
}
