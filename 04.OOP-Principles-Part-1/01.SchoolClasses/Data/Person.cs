namespace School.Data
{
    using System;

    public abstract class Person : IComentable
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName, string comment = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Comment = comment;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect last name!");
                }

                this.lastName = value;
            }
        }

        public string Comment { get; private set; }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
