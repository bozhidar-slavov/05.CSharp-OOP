namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var test = new StringBuilder("StringBuilderExtensionMethod");

            string firstTest = "StringBuilderExtensionMethod";
            string secondTest = "StringBuilderExtensionMethod";

            Console.WriteLine(test.Substring(6, 7));
            Console.WriteLine(firstTest.Substring(6, 7));

            Console.WriteLine(test.Substring(13));
            Console.WriteLine(secondTest.Substring(13));
        }
    }
}
