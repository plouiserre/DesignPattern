using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public class HighSchoolFactory : EtablishmentFactory
    {
        public HighSchoolFactory()
        {
        }

        public override Etablishment CreateEtablishment(string name)
        {
            var highSchool = new HighSchool(name);
            return highSchool;
        }

        public override Pupil CreatePupil(string firstName, string lastName, string level, Etablishment etablishment)
        {
            var pupil = new HighSchoolPupil(firstName, lastName, level, etablishment.Name);
            return pupil;
        }

        public override Teacher CreateTeacher(string firstName, string lastName, string discipline, Etablishment etablishment)
        {
            var teacher = new HighSchoolTeacher(firstName, lastName, discipline, etablishment.Name);
            return teacher;
        }
    }
}
