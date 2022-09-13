using System;
namespace CreationalPattern.Product.AbstractFactory
{
    public class HighSchoolStudent : IStudent
    {
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string EtablishmentName { get ; set; }
        public string Level { get ; set ; }

        public HighSchoolStudent(string firstName, string lastName, string etablishmentName, string level)
        {
            FirstName = firstName;
            LastName = lastName;
            EtablishmentName = etablishmentName;
            Level = level;
        }

        public string GetLevel()
        {
            return Level;
        }
    }
}

