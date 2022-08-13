using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class HighSchoolFactory : EtablishmentFactory
    {
        public HighSchoolFactory()
        {
        }

        public override AbstractEtablishment CreateEtablishment(string name)
        {
            var highSchool = new HighSchool(name);
            return highSchool;
        }

        public override AbstractPupil CreatePupil(string firstName, string lastName, string level, AbstractEtablishment etablishment)
        {
            var pupil = new HighSchoolPupil(firstName, lastName, level, etablishment.Name);
            return pupil;
        }

        public override AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, AbstractEtablishment etablishment)
        {
            var teacher = new HighSchoolTeacher(firstName, lastName, discipline, etablishment.Name);
            return teacher;
        }
    }
}
