using System;
namespace CreationalPattern.AbstractFactory.Product
{
    public abstract class AbstractTeacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public object Discipline { get; set; }

        public AbstractTeacher(string firstName, string lastName, string discipline)
        {
            FirstName = firstName;
            LastName = lastName;
            Discipline = discipline;
        }
    }
}
