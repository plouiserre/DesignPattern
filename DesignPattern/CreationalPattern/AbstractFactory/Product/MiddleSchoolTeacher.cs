using System;
namespace CreationalPattern.AbstractFactory.Product
{
    public class MiddleSchoolTeacher : AbstractTeacher
    {
        public string MiddleSchoolName { get; set; }

        public MiddleSchoolTeacher(string middleSchoolName, string firstName, string lastName, string discipline) :
            base(firstName, lastName, discipline)
        {
            MiddleSchoolName = middleSchoolName;
        }
    }
}
