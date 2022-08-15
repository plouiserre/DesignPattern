using System;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public class HighSchoolBuilder : EtablishmentBuilder
    {
        private Etablishment _currentEtablishment { get; set; }

        public HighSchoolBuilder()
        {
        }

        public override void BuildEtablishment(string name)
        {
            _currentEtablishment = new HighSchool(name);
        }

        public override void BuildPupil(string firstName, string lastName, string level)
        {
            var pupil = new HighSchoolPupil(firstName, lastName, level, _currentEtablishment.Name);
            _currentEtablishment.AddPupil(pupil);
        }

        public override void BuildTeacher(string firstName, string lastName, string discipline)
        {
            var teacher = new HighSchoolTeacher(firstName, lastName, discipline, _currentEtablishment.Name);
            _currentEtablishment.AddTeacher(teacher);
        }

        public override Etablishment GetEtablishment()
        {
            return _currentEtablishment;
        }
    }
}

