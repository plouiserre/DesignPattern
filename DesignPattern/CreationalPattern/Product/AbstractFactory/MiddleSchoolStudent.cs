using System;
namespace CreationalPattern.Product.AbstractFactory
{
    public class MiddleSchoolStudent : IStudent
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EtablishmentName { get; set ; }

        public string Level { get ; set ; }

        public MiddleSchoolStudent(string firstName, string lastName, string level, string etablishmentName)
        {
            FirstName = firstName;
            LastName = lastName;
            Level = level;
            EtablishmentName = etablishmentName;
        }

        public string GetLevel()
        {
            return Level;
        }
    }
}

