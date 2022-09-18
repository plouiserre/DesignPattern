using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class HighSchoolFactory : EtablishmentFactory
    {
        public HighSchoolFactory()
        {
        }

        public IStudent CreateStudent(string firstName, string lastName, string level, string etablishmentName)
        {
            var student = new HighSchoolStudent(firstName, lastName, level, etablishmentName);
            return student;
        }

        public ITeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName)
        {
            var teacher = new HighSchoolTeacher(firstName, lastName, discipline, etablishmentName);
            return teacher;
        }
    }
}
