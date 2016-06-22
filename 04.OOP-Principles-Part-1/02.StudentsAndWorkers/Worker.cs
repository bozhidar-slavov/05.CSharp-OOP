namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workingHours;

        private const int workDays = 5;

        public Worker(string firstName, string lastName, double weekSalary, double workingHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary must be positive number!");
                }

                this.weekSalary = value;
            }
        }

        public double WorkingHours
        {
            get
            {
                return this.workingHours;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Working hours must be positive number!");
                }

                this.workingHours = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = (this.weekSalary / workDays) / this.workingHours;
            return moneyPerHour;
        }
    }
}
