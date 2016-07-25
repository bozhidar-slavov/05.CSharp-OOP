namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;

    using System.Collections.Generic;
    using System.Text;

    public abstract class Vehicle : IVehicle
    {
        private string make;
        private string model;
        private decimal price;
        private int wheels;
        private IList<IComment> comments;
        private VehicleType type;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public IList<IComment> Comments
        {
            get { return this.comments; }

            protected set
            {
                Validator.ValidateNull(value, "Comments cannot be null!");

                this.comments = value;
            }
        }

        public string Make
        {
            get { return this.make; }

            protected set
            {
                Validator.ValidateNull(value, "Make cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));

                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }

            protected set
            {
                Validator.ValidateNull(value, "Model cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));

                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }

            protected set
            {
                Validator.ValidateNull(value, "Price cannot be null!");
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));

                this.price = value;
            }
        }

        public VehicleType Type
        {
            get { return this.type; }

            protected set
            {
                Validator.ValidateNull(value, "Vehicle type cannot be null!");

                this.type = value;
            }
        }
        
        public int Wheels
        {
            get { return this.wheels; }

            protected set
            {
                Validator.ValidateNull(value, "Wheels cannot be null!");
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Wheels", Constants.MinWheels, Constants.MaxWheels));

                this.wheels = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("  Make: {0}", this.Make));
            result.Append(string.Format("  Model: {0}", this.Model));

            return result.ToString();
        }
    }
}
