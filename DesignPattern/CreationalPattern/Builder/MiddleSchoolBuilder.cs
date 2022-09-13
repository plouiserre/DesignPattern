using System;
using CreationalPattern.Product;
using CreationalPattern.Product.AbstractFactory;

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

        public void BuildStudent(IStudent student)
        {
            var studentMiddleSchool = student as MiddleSchoolStudent;
            studentMiddleSchool.EtablishmentName = _currentEtablishment.Name;
            _currentEtablishment.AddStudent(studentMiddleSchool);
        }

        public void BuildTeacher(ITeacher teacher)
        {
            var teacherMiddleSchool = teacher as Product.AbstractFactory.MiddleSchoolTeacher;
            teacherMiddleSchool.EtablishmentName = _currentEtablishment.Name;
            _currentEtablishment.AddTeacher(teacher);
        }

        public Etablishment GetEtablishment()
        {
            return _currentEtablishment;
        }
    }
}

