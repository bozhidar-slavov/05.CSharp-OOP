using System;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISoundable
    {
        public Cat(string name, Gender sex, int age)
            : base(name, sex, age)
        {
            this.Species = Species.Cat;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow-meoow!");
        }
    }
}
