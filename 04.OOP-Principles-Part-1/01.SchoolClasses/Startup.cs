namespace School
{
    using Data;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var nakovDisciplines = new List<Disciplines>
            {
                new Disciplines(DisciplineName.Math, 10, 10),
                new Disciplines(DisciplineName.Informatics, 20, 20)
            };

            var kiroDisciplines = new List<Disciplines>
            {
                new Disciplines(DisciplineName.History, 8, 8),
                new Disciplines(DisciplineName.Geography, 6, 6)
            };

            var studentsClassA = new List<Student>
            {
                new Student("Pesho", "Peshov"),
                new Student("Gosho", "Goshov"),
                new Student("Ivo", "Ivov")
            };

            var studentsClassB = new List<Student>
            {
                new Student("Mariika", "Mariikova"),
                new Student("Todorka", "Todorkova"),
                new Student("Stoyanka", "Stoyankova")
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Svetlin", "Nakov", nakovDisciplines),
                new Teacher("Kiro", "Kirov", kiroDisciplines)
            };

            var classA = new SchoolClass(teachers, studentsClassA);
            var classB = new SchoolClass(teachers, studentsClassB);

            var school = new School(new List<SchoolClass> { classA, classB });

            Console.WriteLine(school);
        }
    }
}
