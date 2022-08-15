using System;
namespace CreationalPattern.Product
{
    //TODO add the last property created in other pattern
    public class HighSchoolPupil : Pupil
    {

        public bool IsSmoking { get; set; }

        public HighSchoolPupil(string firstName, string lastName, string level, string highSchoolName) :
            base(firstName, lastName, level, highSchoolName)
        {
            
        }
    }
}
