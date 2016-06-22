namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat, ISoundable
    {
        public Kitten(string name, int age)
            : base(name, Gender.Female, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mrrr-mrrr!");
        }
    }
}
