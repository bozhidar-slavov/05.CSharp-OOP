namespace School.Data
{
    using System.Collections.Generic;
    
    public class Teacher : Person, IComentable
    {
        private List<Disciplines> disciplines;

        public Teacher(string firstName, string lastName, List<Disciplines> disciplines, string comment = null)
            : base(firstName, lastName, comment)
        {
            this.Disciplines = disciplines;
        }

        public List<Disciplines> Disciplines { get; set; }
    }
}
