using System;
namespace CreationalPattern.Product.AbstractFactory
{
    public class HighSchoolTeacher : ITeacher
    {
        public string Discipline { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EtablishmentName { get; set; }

        public HighSchoolTeacher(string firstName, string lastName, string etablishmentName, string discipline)
        {
            FirstName = firstName;
            LastName = lastName;
            EtablishmentName = etablishmentName;
            Discipline = discipline;
        }

        public string GetDiscipline()
        {
            return Discipline;
        }
    }
}

