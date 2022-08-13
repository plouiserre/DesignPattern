using System;
namespace CreationalPattern.Product
{
    public class MiddleSchoolPupil : AbstractPupil
    {
        public MiddleSchoolPupil(string firstName, string lastName, string level, string middleSchoolName) :
            base(firstName, lastName, level, middleSchoolName)
        {
        }
    }
}
