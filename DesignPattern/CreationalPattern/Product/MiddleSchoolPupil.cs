using System;
namespace CreationalPattern.Product
{
    public class MiddleSchoolPupil : Pupil
    {
        public bool isIlletrate { get; set; }

        public MiddleSchoolPupil(string firstName, string lastName, string level, string middleSchoolName) :
            base(firstName, lastName, level, middleSchoolName)
        {
        }
    }
}
