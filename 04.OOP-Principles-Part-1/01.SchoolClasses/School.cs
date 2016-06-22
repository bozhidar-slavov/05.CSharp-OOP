namespace School
{
    using Data;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<SchoolClass> schoolClasses = new List<SchoolClass>();
        
        public School(List<SchoolClass> newClasses)
        {
            this.SchoolClasses = newClasses;
        }
        
        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }
            set
            {
                this.schoolClasses = value;
            }
        }


        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var schoolClass in SchoolClasses)
            {
                result.AppendLine(schoolClass.ToString());
            }

            return result.ToString();
        }
    }
}
