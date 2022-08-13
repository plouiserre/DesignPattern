using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class MiddleSchoolFactory : EtablishmentFactory
    {
        public MiddleSchoolFactory()
        {
        }

        public override AbstractEtablishment CreateEtablishment(string name)
        {
            var middleSchool = new MiddleSchool(name);
            return middleSchool;
        }

        public override AbstractPupil CreatePupil(string firstName, string lastName, string level, AbstractEtablishment etablishment)
        {
            var pupil = new MiddleSchoolPupil(firstName, lastName, level, etablishment.Name);
            return pupil;
        }

        public override AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, AbstractEtablishment etablishment)
        {
            var teacher = new MiddleSchoolTeacher(firstName, lastName, discipline, etablishment.Name);
            return teacher;
        }
    }
}
