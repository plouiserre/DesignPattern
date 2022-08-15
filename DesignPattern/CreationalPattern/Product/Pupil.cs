using System;
namespace CreationalPattern.Product
{
    public class Pupil
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Level { get; set; }

        public string EtablishmentName { get; set; }

        public Pupil(string lastName, string firstName, string level, string etablishmentName)
        {
            LastName = lastName;
            FirstName = firstName;
            Level = level;
            EtablishmentName = etablishmentName;
        }
    }
}
