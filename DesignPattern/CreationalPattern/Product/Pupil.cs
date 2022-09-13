using System;
namespace CreationalPattern.Product
{
    public class IPupil
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Level { get; set; }

        public string EtablishmentName { get; set; }

        public IPupil(string lastName, string firstName, string level, string etablishmentName)
        {
            LastName = lastName;
            FirstName = firstName;
            Level = level;
            EtablishmentName = etablishmentName;
        }
    }
}
