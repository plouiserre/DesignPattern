using System;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public class MiddleSchoolBuilder : EtablishmentBuilder
    {
        private AbstractEtablishment _currentEtablishment { get; set; }

        public MiddleSchoolBuilder()
        {
        }

        public override void BuildEtablishment(string name)
        {
            _currentEtablishment = new MiddleSchool(name);
        }

        public override void BuildPupil(string firstName, string lastName, string level)
        {
            var pupil = new MiddleSchoolPupil(firstName, lastName, level, _currentEtablishment.Name);
            _currentEtablishment.AddPupil(pupil);
        }

        public override void BuildTeacher(string firstName, string lastName, string discipline)
        {
            var teacher = new MiddleSchoolTeacher(firstName, lastName, discipline, _currentEtablishment.Name);
            _currentEtablishment.AddTeacher(teacher);
        }

        public override AbstractEtablishment GetEtablishment()
        {
            return _currentEtablishment;
        }
    }
}

