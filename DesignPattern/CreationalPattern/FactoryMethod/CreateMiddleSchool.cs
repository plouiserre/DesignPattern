using System;
using CreationalPattern.Product;

namespace CreationalPattern.FactoryMethod
{
    public class CreateMiddleSchool : CreateEtablishment
    {
        public CreateMiddleSchool(string etablishmentName) :
            base(etablishmentName)
        {
        }

        public override IStudent MakeStudent(string firstName, string lastName, string level)
        {
            var student = new MiddleSchoolStudent(firstName, lastName, _etablishmentName, level);
            return student;
        }

        public override ITeacher MakeTeacher(string firstName, string lastName, string discipline)
        {
            var teacher = new MiddleSchoolTeacher(firstName, lastName, _etablishmentName, discipline);
            return teacher;
        }
    }
}

