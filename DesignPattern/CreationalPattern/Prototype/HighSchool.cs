using System;
namespace CreationalPattern.Prototype
{
    public class HighSchool : Etablishment
    {
        public int AdultsStudentsNumber { get; set; }

        public HighSchool()
        {
        }

        public HighSchool(HighSchool hs) :base(hs)
        {
            AdultsStudentsNumber = hs.AdultsStudentsNumber;
        }

        public override Etablishment Clone()
        {
            return new HighSchool(this);
        }
    }
}

