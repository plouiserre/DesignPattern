using System;
using CreationalPattern.AbstractFactory.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class MiddleSchoolFactory : EtablishmentFactory
    {
        public MiddleSchoolFactory()
        {
        }

        public override AbstractPupil CreatePupil(string firstName, string lastName, string level, string etablishmentName)
        {
            var pupil = new MiddleSchoolPupil(etablishmentName, firstName, lastName, level);
            return pupil;
        }

        public override AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName)
        {
            var teacher = new MiddleSchoolTeacher(etablishmentName, firstName, lastName, discipline);
            return teacher;
        }
    }
}
