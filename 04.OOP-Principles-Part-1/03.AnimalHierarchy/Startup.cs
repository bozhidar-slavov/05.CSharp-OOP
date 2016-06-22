namespace AnimalHierarchy
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Animal[] animals =
            {
                new Dog("Silvester", Gender.Male, 4),
                new Dog("Cezar", Gender.Male, 3),
                new Dog("Tara", Gender.Female, 7),
                new Dog("Aira", Gender.Female, 5),

                new Frog("Kyrmit", Gender.Male, 10),
                new Frog("Kiki", Gender.Female, 1),
                new Frog("Koki", Gender.Male, 3),

                new Cat("Serdjo", Gender.Male, 9),
                new Tomcat("Gancho", 5),
                new Kitten("Poli",  2)
            };

            Console.WriteLine(Animal.AverageAge(animals));
            Console.WriteLine();

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
