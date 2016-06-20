namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, string fn, string tel, string email, List<int> marks, int groupNumber, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Fn = fn;
            this.PhoneNumber = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Group = group;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Fn { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("First name: {0}\n", this.FirstName);
            output.AppendFormat("Last name: {0}\n", this.LastName);
            output.AppendFormat("Faculty number: {0}\n", this.Fn);
            output.AppendFormat("Phone number: {0}\n", this.PhoneNumber);
            output.AppendFormat("Email: {0}\n", this.Email);
            output.AppendFormat("Marks: {0}\n", string.Join(", ", this.Marks));
            output.AppendFormat("Group: {0}", this.GroupNumber);

            return output.ToString();
        }
    }
}
