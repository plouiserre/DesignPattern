using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class MiddleSchoolFactory : EtablishmentFactory
    {
        public MiddleSchoolFactory()
        {
        }

        public IStudent CreateStudent(string firstName, string lastName, string level, string etablishmentName)
        {
            var pupil = new MiddleSchoolStudent(firstName, lastName, level, etablishmentName);
            return pupil;
        }

        public ITeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName)
        {
            var teacher = new MiddleSchoolTeacher(firstName, lastName, discipline, etablishmentName);
            return teacher;
        }
    }
}
