namespace GSM.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        public static readonly GSM IPhone4S = new GSM("iPhone 4S", "Apple", 500, "Ivanka", new Battery(BatteryType.Li_Ion, 48, 24), new Display(4.5, 16000000));
        private string model;
        private string manufacturer;
        private decimal? price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }

        public string Owner { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model must be set!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer must be set!");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be positive number!");
                }

                this.price = value;
            }
        }

        public string CallHistory
        {
            get
            {
                if (callHistory.Count == 0)
                {
                    return "Call history is empty!";
                }
                else
                {
                    var callInfo = new StringBuilder();

                    for (int i = 1; i <= callHistory.Count; i++)
                    {
                        callInfo.AppendFormat("{0}. {1}\n", i, this.callHistory[i - 1]);
                    }

                    return callInfo.ToString().TrimEnd('\n');
                }
            }
        }

        public override string ToString()
        {
            var allInformation = new StringBuilder();

            allInformation.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            allInformation.AppendFormat("Model: {0}\n", this.model);

            if (this.price != null)
            {
                allInformation.AppendFormat("Price: {0:C2}\n", this.price);
            }

            if (this.Owner != null)
            {
                allInformation.AppendFormat("Owner: {0}\n", this.Owner);
            }

            allInformation.AppendFormat("Battery: {0}\n", this.battery);
            allInformation.AppendFormat("Display: {0}\n", this.display);

            return allInformation.ToString();
        }

        public decimal GetPrice()
        {
            decimal price = 0M;
            foreach (var call in this.callHistory)
            {
                price += call.DurationInSeconds / 60M * Call.PricePerMinute;
            }

            return price;
        }

        public void AddCall(DateTime dateTime, string dialedNumber, int duration)
        {
            this.callHistory.Add(new Call(dateTime, dialedNumber, duration));
        }

        public void DeleteCall(int callNumber)
        {
            if (callNumber > this.callHistory.Count)
            {
                throw new ArgumentException("There isn't such call.");
            }

            this.callHistory.RemoveAt(callNumber - 1);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public void RemoveLongestCall()
        {
            int maxDurationIndex = 0;
            int maxDuration = 0;

            if (this.callHistory.Count > 0)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    if (this.callHistory[i].DurationInSeconds > maxDuration)
                    {
                        maxDuration = this.callHistory[i].DurationInSeconds;
                        maxDurationIndex = i;
                    }
                }

                this.callHistory.RemoveAt(maxDurationIndex);
            }
            else
            {
                Console.WriteLine("Call history is empty.");
            }
        }
    }
}
