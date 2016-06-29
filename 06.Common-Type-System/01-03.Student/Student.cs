namespace Student
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string fName, string mName, string lName, string ssn, string address,
            string mobilePhone, string email, uint course, Universities uni, Faculties fac, Specialties spec)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = uni;
            this.Faculty = fac;
            this.Speciality = spec;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public string SSN { get; private set; }

        public string Address { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public uint Course { get; private set; }

        public Universities University { get; }

        public Faculties Faculty { get; }

        public Specialties Speciality { get; }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;
            if (this.SSN == objAsStudent.SSN)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\nSSN: {2}\nUniveristy: {3}", this.FirstName, this.LastName, this.SSN, this.University);
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, 
                this.MobilePhone, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        public int CompareTo(Student other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);

            if (result == 0)
            {
                result = this.MiddleName.CompareTo(other.MiddleName);
            }

            if (result == 0)
            {
                result = this.LastName.CompareTo(other.LastName);
            }

            if (result == 0)
            {
                result = this.SSN.CompareTo(other.SSN);
            }

            return result;
        }
    }
}