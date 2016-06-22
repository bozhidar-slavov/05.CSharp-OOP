namespace School.Data
{
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass : IComentable
    {
        private static char autoId = 'A';

        public char ClassId { get; private set; }

        private List<Teacher> teachers;
        private List<Student> students;

        public SchoolClass(List<Teacher> teachers, List<Student> students, string comment = null)
        {
            this.ClassId = autoId;
            this.Teachers = teachers;
            this.Students = students;
            this.Comment = comment;

            autoId++;
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public string Comment { get; set; }

        public string GetDisciplines()
        {
            HashSet<string> classDisciplines = new HashSet<string>();

            foreach (var teacher in this.teachers)
            {
                foreach (var discipline in teacher.Disciplines)
                {
                    classDisciplines.Add(discipline.Name.ToString());
                }
            }

            return string.Join(", ", classDisciplines);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("Class: {0}", this.ClassId));
            result.AppendLine("Teachers: ");
            result.AppendLine(string.Join(", ", this.teachers) + "\n");
            result.AppendLine("Students: ");
            result.AppendLine(string.Join(", ", this.students) + "\n");
            result.AppendLine("Disciplines: ");
            result.AppendLine(this.GetDisciplines());

            return result.ToString();

        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
