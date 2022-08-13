using System;
namespace CreationalPattern.Product
{
    public class HighSchoolPupil : AbstractPupil
    {
        public HighSchoolPupil(string firstName, string lastName, string level, string highSchoolName) :
            base(firstName, lastName, level, highSchoolName)
        {
        }
    }
}
