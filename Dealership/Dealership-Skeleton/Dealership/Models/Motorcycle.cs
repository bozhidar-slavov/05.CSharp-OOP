namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;

    using System.Text;

    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;
        private int wheels = (int)VehicleType.Motorcycle;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get { return this.category; }

            protected set
            {
                Validator.ValidateNull(value, "Category cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));

                this.category = value;
            }
        }

        public new int Wheels
        {
            get { return this.wheels; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(this.GetType().Name.ToString() + ":");
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format("  Wheels: {0}", this.Wheels));
            result.AppendLine(string.Format("  Price: ${0}", this.Price));
            result.Append(string.Format("  Category: {0}", this.Category));

            return result.ToString();
        }
    }
}
