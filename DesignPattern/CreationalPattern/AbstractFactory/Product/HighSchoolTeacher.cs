using System;
namespace CreationalPattern.AbstractFactory.Product
{
    public class HighSchoolTeacher : AbstractTeacher
    {
        public string HighSchoolName { get; set; }

        public HighSchoolTeacher(string highSchoolName, string firstName, string lastName, string discipline) :
            base(firstName, lastName, discipline)
        {
            HighSchoolName = highSchoolName;
        }
    }
}
