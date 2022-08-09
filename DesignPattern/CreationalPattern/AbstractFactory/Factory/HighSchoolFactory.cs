using System;
using CreationalPattern.AbstractFactory.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class HighSchoolFactory : EtablishmentFactory
    {
        public HighSchoolFactory()
        {
        }

        public override AbstractPupil CreatePupil(string firstName, string lastName, string level, string etablishmentName)
        {
            var pupil = new HighSchoolPupil(etablishmentName, firstName, lastName, level);
            return pupil;
        }

        public override AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName)
        {
            var teacher = new HighSchoolTeacher(etablishmentName, firstName, lastName, discipline);
            return teacher;
        }
    }
}
