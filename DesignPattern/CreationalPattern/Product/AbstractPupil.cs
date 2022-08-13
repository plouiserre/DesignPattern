using System;
namespace CreationalPattern.Product
{
    public abstract class AbstractPupil
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Level { get; set; }

        public string EtablishmentName { get; set; }

        public AbstractPupil(string lastName, string firstName, string level, string etablishmentName)
        {
            LastName = lastName;
            FirstName = firstName;
            Level = level;
            EtablishmentName = etablishmentName;
        }
    }
}
