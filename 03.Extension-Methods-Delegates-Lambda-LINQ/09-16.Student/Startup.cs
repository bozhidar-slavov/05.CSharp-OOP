namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static List<Student> students;

        public static void Main()
        {
            // tasks from 9 to 16

            students = new List<Student>()
           {
               new Student(
                   firstName: "Kiro",
                   lastName: "Kirov",
                   fn: "471906",
                   tel: "026543",
                   email: "kiro-noja@gmail.bg",
                   marks: new List<int> { 3, 6 },
                   groupNumber: 1,
                   group: new Group(1, "Informatics")),

               new Student(
                   firstName: "Pesho",
                   lastName: "Peshev",
                   fn: "481906",
                   tel: "022133",
                   email: "pesho-koshmara@abv.bg",
                   marks: new List<int> { 4, 5 },
                   groupNumber: 1,
                   group: new Group(1, "Informatics")),

               new Student(
                   firstName: "Ivo",
                   lastName: "Ivov",
                   fn: "491912",
                   tel: "0883747474",
                   email: "simpatqgata@gmail.com",
                   marks: new List<int> { 6, 6 },
                   groupNumber: 2,
                   group: new Group(2, "Mathematics")),

               new Student(
                   firstName: "Gosho",
                   lastName: "Goshev",
                   fn: "501912",
                   tel: "0888787878",
                   email: "g-goshev@abv.bg",
                   marks: new List<int> { 2, 2 },
                   groupNumber: 2,
                   group: new Group(2, "Mathematics")),
           };

            GetStudentsFromSecondGroup();
            GetStudentsFromABV();
            GetStudentsFromSofia();
            GetExcellentStudents();
            GetStudentsWithTwoMarks2();
            GetStudentsFrom2006();
            GetMathematics();
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        public static void GetStudentsFromSecondGroup()
        {
            Console.WriteLine("Students from second group:\n");

            var studentsFromSecondGroup = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);

            Print(studentsFromSecondGroup);
        }

        public static void GetStudentsFromABV()
        {
            Console.WriteLine("Students with email in abv.bg:\n");

            var studentsFromAbv = students.Where(s => s.Email.Contains("@abv.bg"));

            Print(studentsFromAbv);
        }

        public static void GetStudentsFromSofia()
        {
            Console.WriteLine("Students from Sofia:\n");

            var studentsFromSofia = students.Where(s => s.PhoneNumber.StartsWith("02"));

            Print(studentsFromSofia);
        }

        public static void GetExcellentStudents()
        {
            Console.WriteLine("Students with at least one excellent mark:\n");

            var studentsWithExcellentMark = students.Where(s => s.Marks.Contains(6)).Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("{0} -> {1}\n", student.FullName, string.Join(", ", student.Marks));
            }
        }

        public static void GetStudentsWithTwoMarks2()
        {
            Console.WriteLine("Students with two marks 2:\n");

            var studentsWithTwoMarks2 = students.Where(s => s.Marks.Count == 2 && s.Marks.All(a => a == 2)).Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });

            foreach (var student in studentsWithTwoMarks2)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, string.Join(", ", student.Marks));
            }
        }

        public static void GetStudentsFrom2006()
        {
            Console.WriteLine("Student marks from 2006:\n");

            var studentMarksFrom2006 = students.Where(s => s.Fn.Substring(4, 2).Equals("06")).Select(s => new { FullName = s.FirstName + " " + s.LastName, Fn = s.Fn, Marks = s.Marks });

            foreach (var student in studentMarksFrom2006)
            {
                Console.WriteLine("{0} {1} -> {2}", student.FullName, student.Fn, string.Join(", ", student.Marks));
            }
        }

        public static void GetMathematics()
        {
            Console.WriteLine("All students from mathematics department:\n");

            var studentsFromMathDepartment = students.Where(s => s.Group.DepartmentName.Equals("Mathematics"))
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, Department = s.Group.DepartmentName, DepartmentNumber = s.GroupNumber });

            foreach (var student in studentsFromMathDepartment)
            {
                Console.WriteLine("Group: {0}, {1} -> {2}\n", student.DepartmentNumber, student.Department, student.FullName);
            }
        }
    }
}
