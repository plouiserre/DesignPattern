using System;
using CreationalPattern.Product;

namespace CreationalPattern.FactoryMethod
{
    public class CreateHighSchool : CreateEtablishment
    {
        public CreateHighSchool(string etablishmentName) : base(etablishmentName)
        {
        }

        public override IStudent MakeStudent(string firstName, string lastName, string level)
        {
            HighSchoolStudent student = new HighSchoolStudent(firstName, lastName, _etablishmentName, level);
            return student;
        }

        public override ITeacher MakeTeacher(string firstName, string lastName, string discipline)
        {
            HighSchoolTeacher teacher = new HighSchoolTeacher(firstName, lastName, _etablishmentName, discipline);
            return teacher;
        }
    }
}

