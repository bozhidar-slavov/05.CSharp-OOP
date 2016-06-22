namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Pesho", "Peshov", 5.50),
                new Student("Gosho", "Goshov", 4.75),
                new Student("Ivo", "Ivov", 5.75),
                new Student("Ganka", "Gancheva", 4.25),
                new Student("Ivanka", "Ivanova", 5.10),
                new Student("Mariika", "Todorova", 6.00),
                new Student("Kosta", "Conev", 3.80),
                new Student("Kostadinka", "Markova", 5.30),
                new Student("Iliqn", "Velichkov", 4.10),
                new Student("Mitko", "Mitkov", 5.60)
            };

            var orderByGrade = students.OrderBy(x => x.Grade);

            foreach (var student in orderByGrade)
            {
                Console.WriteLine("Name: {0} {1} | Grade: {2:F2}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine();

            var workers = new List<Worker>
            {
                new Worker("Genadi", "Genadiev", 500, 10),
                new Worker("Bai", "Petko", 400, 12),
                new Worker("Georgi", "Grozdanov", 1200, 8),
                new Worker("Filip", "Stanev", 3000, 12),
                new Worker("Diqna", "Mladenova", 5000, 8),
                new Worker("Siika", "Kozhuharova", 600, 12),
                new Worker("Koprinka", "Bojurova", 450, 10),
                new Worker("Stefan", "Sharlopov", 900, 12),
                new Worker("Sava", "Piperov", 1600, 4),
                new Worker("Miho", "Mihov", 1000, 10)
            };

            var sortedByMoney = workers.OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in sortedByMoney)
            {
                Console.WriteLine("Name: {0} {1} | Money per hour: {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine("\nMerged and sorted by first and last name: ");

            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in merged)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }
    }
}
