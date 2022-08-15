using System;
namespace CreationalPattern.Product
{
    public class Teacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Discipline { get; set; }

        public string EtablishmentName { get; set; }

        public Teacher(string firstName, string lastName, string discipline, string etablishmentName)
        {
            FirstName = firstName;
            LastName = lastName;
            Discipline = discipline;
            EtablishmentName = etablishmentName;
        }
    }
}
