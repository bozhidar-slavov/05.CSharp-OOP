namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal, ISoundable
    {
        public Frog(string name, Gender sex, int age)
            : base(name, sex, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Krqk-krqk!");
        }
    }
}
