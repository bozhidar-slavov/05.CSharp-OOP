namespace AgeRange
{
    using System;
    using System.Linq;

    public class StudentsAge
    {
        public static void Main()
        {
            var arrayOfStudents = new[]
            {
                new { FirstName = "Ivan", LastName = "Angelov", Age = 15 },
                new { FirstName = "Angel", LastName = "Ivanov", Age = 20 },
                new { FirstName = "Gosho", LastName = "Zlatev", Age = 27 },
                new { FirstName = "Zlati", LastName = "Goshov", Age = 23 }
            };

            var ageBetween18And24 = arrayOfStudents.Where(s => s.Age >= 18 && s.Age <= 24);

            Console.WriteLine("Students between 18 and 24 years old:");
            foreach (var student in ageBetween18And24)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
