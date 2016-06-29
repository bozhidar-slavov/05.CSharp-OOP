namespace Array64Bit
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong value;
        private int[] bitArray;

        public BitArray64(ulong value = 0)
        {
            this.Value = value;
        }

        public ulong Value
        {
            get
            {
                return this.GetValue(this.bitArray);
            }

            set
            {
                this.value = value;
                this.bitArray = this.GetBits(value);
            }
        }

        public int this[int index]
        {
            get
            {
                return this.bitArray[index];
            }

            set
            {
                if (value != 1 && value != 0)
                {
                    throw new ArgumentException("Value must be 0 or 1!");
                }

                this.bitArray[index] = value;
                this.value = this.GetValue(this.bitArray);
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this.bitArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.bitArray);
        }

        public override bool Equals(object obj)
        {
            var arrayAsObj = obj as BitArray64;

            if ((object)arrayAsObj == null)
            {
                return false;
            }

            return BitArray64.Equals(this.value, arrayAsObj.value);
        }

        private int[] GetBits(ulong input)
        {
            int[] result = new int[64];
            int bitIndex = 63;

            while (input != 0)
            {
                result[bitIndex] = (int)(input % 2);

                bitIndex--;
                input >>= 1;
            }

            return result;
        }

        private ulong GetValue(int[] bits)
        {
            ulong result = 0;

            for (int i = 63; i >= 0; i--)
            {
                if (bits[i] == 1)
                {
                    result += (ulong)Math.Pow(2, bits.Length - 1 - i);
                }
            }

            return result;
        }
    }
}
