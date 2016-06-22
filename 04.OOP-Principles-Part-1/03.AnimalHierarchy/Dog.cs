namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISoundable
    {
        public Dog(string name, Gender sex, int age)
            : base(name, sex, age)
        {
        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Waf-waf, Bau-bau!");
        }
    }
}
