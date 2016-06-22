namespace AnimalHierarchy
{
    using System;

    public class Tomcat: Cat, ISoundable
    {
        public Tomcat(string name, int age)
            : base(name, Gender.Male, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mquuuuuuu!");
        }
    }
}
