namespace Array64Bit
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var bitsArray = new BitArray64(128);
            Console.WriteLine("Bits: {0}", bitsArray);
            Console.WriteLine("Value: {0}\n", bitsArray.Value);

            // change index in array
            bitsArray[30] = 1;
            Console.WriteLine("Bits: {0}", bitsArray);
            Console.WriteLine("Value: {0}\n", bitsArray.Value);

            Console.Write("Bits: ");
            var maxArray = new BitArray64(ulong.MaxValue);
            foreach (var bit in maxArray)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine("Value: {0}\n", maxArray.Value);

            var newArray = new BitArray64(32);
            Console.WriteLine(bitsArray.Equals(newArray));
            Console.WriteLine(newArray != bitsArray);
        }
    }
}
