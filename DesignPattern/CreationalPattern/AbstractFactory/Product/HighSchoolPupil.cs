using System;
namespace CreationalPattern.AbstractFactory.Product
{
    public class HighSchoolPupil : AbstractPupil
    {
        public string HighSchoolName { get; set; }

        public HighSchoolPupil(string highschoolname, string firstName, string lastName, string level) :
            base(firstName, lastName, level)
        {
            HighSchoolName = highschoolname;
        }
    }
}
