namespace OrderStudents
{
    using System;
    using System.Linq;

    public class OrderStudents
    {
        public static void Main()
        {
            var arrayOfStudents = new[]
            {
                new { FirstName = "Angel", LastName = "Bojkov" },
                new { FirstName = "Kimbo", LastName = "Slice" },
                new { FirstName = "Boiko", LastName = "Grozev" },
                new { FirstName = "Stamat", LastName = "Zlatev" },
                new { FirstName = "Angel", LastName = "Stamatov"}
            };

            var sortedStudents = arrayOfStudents.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);

            Console.WriteLine("Sorted by descending first name then by descending last name:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
