namespace GroupedByGroupNumber
{
    using System;
    using System.Linq;

    public class GroupedByGroupNumber
    {
        public static void Main()
        {
            var students = new[]
            {
                new { Name = "Cvetko", Group = "Informatics"},
                new { Name = "Todorka", Group = "History"},
                new { Name = "Ivancho", Group = "Informatics"},
                new { Name = "Mariika", Group = "Mathematics"},
                new { Name = "Koprinka", Group = "History"},
                new { Name = "Karamfil", Group = "Mathematics"}
            };

            // 18. LINQ
            // var groupedStudents =
            //    from st in students
            //    group st by st.Group into g
            //    orderby g.Key
            //    select g;

            // prefer this way because using LINQ keywords is old practice...
            var groupedStudents = students.GroupBy(s => s.Group).OrderBy(g => g.Key);

            foreach (var group in groupedStudents)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("{0} -> {1}", student.Group, student.Name);
                }
            }
        }
    }
}
