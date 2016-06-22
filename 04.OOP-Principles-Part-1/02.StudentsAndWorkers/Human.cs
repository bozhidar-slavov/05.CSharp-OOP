namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect last name!");
                }

                this.lastName = value;
            }
        }
    }
}
