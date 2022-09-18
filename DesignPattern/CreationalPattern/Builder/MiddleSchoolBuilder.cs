using System;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public class MiddleSchoolBuilder : EtablishmentBuilder
    {
        private Etablishment _currentEtablishment { get; set; }

        public MiddleSchoolBuilder()
        {
        }

        public void BuildEtablishment(string name)
        {
            _currentEtablishment = new MiddleSchool(name);
        }

        public void BuildStudent(string firstname, string lastname, string level)
        {
            var studentMiddleSchool = new MiddleSchoolStudent(firstname, lastname, level, _currentEtablishment.Name) ;
            _currentEtablishment.AddStudent(studentMiddleSchool);
        }

        public void BuildTeacher(string firstname, string lastname, string discipline)
        {
            var teacherMiddleSchool = new MiddleSchoolTeacher(firstname, lastname, _currentEtablishment.Name, discipline);
            _currentEtablishment.AddTeacher(teacherMiddleSchool);
        }

        public Etablishment GetEtablishment()
        {
            return _currentEtablishment;
        }
    }
}

