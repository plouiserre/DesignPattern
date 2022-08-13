using System;
namespace CreationalPattern.Product
{
    public class HighSchoolTeacher : AbstractTeacher
    {
        public HighSchoolTeacher(string firstName, string lastName, string discipline, string highSchoolName) :
            base(firstName, lastName, discipline, highSchoolName)
        {
        }
    }
}
