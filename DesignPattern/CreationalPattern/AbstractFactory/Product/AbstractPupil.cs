using System;
namespace CreationalPattern.AbstractFactory.Product
{
    public abstract class AbstractPupil
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Level { get; set; }

        public AbstractPupil(string lastName, string firstName, string level)
        {
            LastName = lastName;
            FirstName = firstName;
            Level = level;
        }
    }
}
