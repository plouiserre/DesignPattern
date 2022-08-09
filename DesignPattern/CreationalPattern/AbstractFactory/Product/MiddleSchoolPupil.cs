using System;
namespace CreationalPattern.AbstractFactory.Product
{
    public class MiddleSchoolPupil : AbstractPupil
    {
        public string MiddleSchoolName { get; set; }

        public MiddleSchoolPupil(string middleSchoolName, string firstName, string lastName, string level) :
            base(firstName, lastName, level)
        {
            MiddleSchoolName = middleSchoolName;
        }
    }
}
