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

        public void BuildEtablishment(string name)
        {
            _currentEtablishment = new HighSchool(name);
        }

        public void BuildStudent(string firstname, string lastname, string level)
        {
            var studentHighSchool = new HighSchoolStudent(firstname, lastname, _currentEtablishment.Name, level);
            _currentEtablishment.AddStudent(studentHighSchool);
        }

        public void BuildTeacher(string firstname, string lastname, string discipline)
        {
            var teacherHighSchool = new HighSchoolTeacher(firstname, lastname, _currentEtablishment.Name, discipline);
            _currentEtablishment.AddTeacher(teacherHighSchool);
        }

        public Etablishment GetEtablishment()
        {
            return _currentEtablishment;
        }
    }
}

