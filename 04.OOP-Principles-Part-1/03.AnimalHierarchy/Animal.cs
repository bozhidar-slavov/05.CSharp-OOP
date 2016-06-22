namespace AnimalHierarchy
{
    using System;
    using System.Linq;
    using System.Text;

    public abstract class Animal : ISoundable
    {
        private string name;
        private Gender sex;
        private int age;

        public Animal(string name, Gender sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age {
            get { return this.age; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive number!");
                }

                this.age = value;
            }
        }

        public Gender Sex { get; protected set; }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public abstract void MakeSound();

        public static StringBuilder AverageAge(Animal[] animals)
        {
            var result = new StringBuilder();

            double averageDogsAge = 0;
            double averageFrogsAge = 0;
            double averageCatsAge = 0;

            foreach (var animal in animals)
            {
                averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
                averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
                averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);
            }

            result.AppendFormat("Average dogs age: {0:F2} \n", averageDogsAge);
            result.AppendFormat("Average frogs age: {0:F2} \n", averageFrogsAge);
            result.AppendFormat("Average cats age: {0:F2}", averageCatsAge);

            return result;
        }
    }
}
