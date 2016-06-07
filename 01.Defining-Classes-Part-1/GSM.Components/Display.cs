namespace GSM.Components
{
    using System;
    using System.Text;

    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public Display()
            : this(null, null)
        {
        }

        public double? Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be positive number!");
                }

                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be positive number!");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var displayInfo = new StringBuilder();

            if (this.size != null)
            {
                displayInfo.AppendFormat("Size: {0:F1} inches", this.size);
            }

            if (this.numberOfColors != null)
            {
                displayInfo.AppendFormat(", Colors: {0}", this.numberOfColors);
            }

            return displayInfo.Length > 0 ? displayInfo.ToString() : "No display info";
        }
    }
}
