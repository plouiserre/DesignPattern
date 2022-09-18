using System;
namespace CreationalPattern.Prototype
{
    public class MiddleSchool : Etablishment
    {
        public bool SuburbMiddleSchool { get; set; }

        public MiddleSchool()
        {

        }

        public MiddleSchool(MiddleSchool ms) : base(ms)
        {
            SuburbMiddleSchool = ms.SuburbMiddleSchool;
        }

        public override Etablishment Clone()
        {
            return new MiddleSchool(this);
        }
    }
}

