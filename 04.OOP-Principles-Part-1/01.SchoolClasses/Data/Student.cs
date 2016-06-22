namespace School.Data
{
    public class Student : Person
    {
        private static int autoId = 1;
        
        public Student(string firstName, string lastName, string comment = null)
            :base(firstName, lastName, comment)
        {
            this.ClassNumber = autoId;

            autoId++;
        }
        
        public int ClassNumber { get; private set; }
    }
}
