using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class MiddleSchoolFactory : EtablishmentFactory
    {
        public MiddleSchoolFactory()
        {
        }

        public override Etablishment CreateEtablishment(string name)
        {
            var middleSchool = new MiddleSchool(name);
            return middleSchool;
        }

        public override Pupil CreatePupil(string firstName, string lastName, string level, Etablishment etablishment)
        {
            var pupil = new MiddleSchoolPupil(firstName, lastName, level, etablishment.Name);
            return pupil;
        }

        public override Teacher CreateTeacher(string firstName, string lastName, string discipline, Etablishment etablishment)
        {
            var teacher = new MiddleSchoolTeacher(firstName, lastName, discipline, etablishment.Name);
            return teacher;
        }
    }
}
