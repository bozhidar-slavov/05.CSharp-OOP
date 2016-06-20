namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    public class StudentsNames
    {
        public static void Main()
        {
            // declaring annonymous type array of students
            var arrayOfStudents = new[]
            {
                new { FirstName = "Ivan", LastName = "Angelov" },
                new { FirstName = "Angel", LastName = "Ivanov" },
                new { FirstName = "Gosho", LastName = "Zlatev" },
                new { FirstName = "Zlati", LastName = "Goshov" }
            };

            var targetStudents = arrayOfStudents.Where(s => s.FirstName.CompareTo(s.LastName) < 0);

            Console.WriteLine("First name before its last name alphabetically:");
            foreach (var student in targetStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
