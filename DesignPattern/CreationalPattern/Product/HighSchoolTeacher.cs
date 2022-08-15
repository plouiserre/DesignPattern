using System;
namespace CreationalPattern.Product
{
    public class HighSchoolTeacher : Teacher
    {
        public bool IsAgreation { get; set; }

        public HighSchoolTeacher(string firstName, string lastName, string discipline, string highSchoolName) :
            base(firstName, lastName, discipline, highSchoolName)
        {
        }
    }
}
