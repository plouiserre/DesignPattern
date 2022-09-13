using System;
namespace CreationalPattern.Product
{
    public class MiddleSchoolTeacher : ITeacher
    {
        public string Discipline { get; set; }
        public string FirstName { get; set ; }
        public string LastName { get; set; }
        public string EtablishmentName { get; set; }

        public MiddleSchoolTeacher(string firstName, string lastName, string etablishmentName, string discipline)
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

