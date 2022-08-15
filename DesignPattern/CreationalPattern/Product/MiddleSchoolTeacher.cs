using System;
namespace CreationalPattern.Product
{
    public class MiddleSchoolTeacher : Teacher
    {
        public bool IsIntern { get; set; }

        public MiddleSchoolTeacher(string firstName, string lastName, string discipline, string middleSchoolName) :
            base(firstName, lastName, discipline, middleSchoolName)
        {

        }
    }
}
