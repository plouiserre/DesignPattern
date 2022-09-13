using System;
using CreationalPattern.Product;
using CreationalPattern.Product.AbstractFactory;

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

        public void BuildStudent(IStudent student)
        {
            var studentHighSchool = student as HighSchoolStudent;
            studentHighSchool.EtablishmentName = _currentEtablishment.Name;
            _currentEtablishment.AddStudent(studentHighSchool);
        }

        public void BuildTeacher(ITeacher teacher)
        {
            var teacherHighSchool = teacher as Product.AbstractFactory.HighSchoolTeacher;
            teacherHighSchool.EtablishmentName = _currentEtablishment.Name;
            _currentEtablishment.AddTeacher(teacherHighSchool);
        }

        public Etablishment GetEtablishment()
        {
            return _currentEtablishment;
        }
    }
}

