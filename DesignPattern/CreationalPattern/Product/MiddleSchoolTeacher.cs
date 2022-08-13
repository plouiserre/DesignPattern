using System;
namespace CreationalPattern.Product
{
    public class MiddleSchoolTeacher : AbstractTeacher
    {
        public MiddleSchoolTeacher(string firstName, string lastName, string discipline, string middleSchoolName) :
            base(firstName, lastName, discipline, middleSchoolName)
        {

        }
    }
}
