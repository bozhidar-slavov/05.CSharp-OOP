namespace School.Data
{
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass : IComentable
    {
        private static char autoId = 'A';

        public char ClassId { get; private set; }

        public SchoolClass(List<Teacher> teachers, List<Student> students, string comment = null)
        {
            this.ClassId = autoId;
            this.Teachers = teachers;
            this.Students = students;
            this.Comment = comment;

            autoId++;
        }

        public List<Teacher> Teachers { get; private set; }

        public List<Student> Students { get; private set; }

        public string Comment { get; private set; }

        public string GetDisciplines()
        {
            var classDisciplines = new HashSet<string>();

            foreach (var teacher in this.Teachers)
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
            result.AppendLine(string.Join(", ", this.Teachers) + "\n");
            result.AppendLine("Students: ");
            result.AppendLine(string.Join(", ", this.Students) + "\n");
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
