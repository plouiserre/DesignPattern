 using System;
using System.Collections.Generic;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public class EtablishmentDirector
    {
        private string _middleSchool;
        private string _highSchool;

        private HighSchoolBuilder _highSchoolBuilder { get; set; }
        private MiddleSchoolBuilder _middleSchoolBuilder { get; set; }

        public EtablishmentDirector()
        {
            _highSchoolBuilder = new HighSchoolBuilder();
            _middleSchoolBuilder = new MiddleSchoolBuilder();
            _highSchool = "Riverdale HighSchool";
            _middleSchool = "Charles Xavier's Institut";
        }

        public Etablishment CreateHighSchool(EtablishmentBuilder builder, string etablishmentName)
        {
            _highSchoolBuilder.BuildStudent("Archie", "Andrews", "11th grade");
            _highSchoolBuilder.BuildStudent("Betty", "Cooper", "11th grade");

            _highSchoolBuilder.BuildTeacher("James", "Howlett", "Sport");
            _highSchoolBuilder.BuildTeacher("Jean", "Grey", "Sciences");
            
            return builder.GetEtablishment();
        }

        public Etablishment CreateMiddleSchool(EtablishmentBuilder builder, string etablishmentName)
        {
            _middleSchoolBuilder.BuildStudent("Veronica", "Lodge", "11th grade");
            _middleSchoolBuilder.BuildStudent("Forsythe", "Pendleton", "11th grade");

            _middleSchoolBuilder.BuildTeacher("Ororo", "Munroe", "Maths");
            _middleSchoolBuilder.BuildTeacher("Scott", "Summers", "Litterature");

            return builder.GetEtablishment();
        }
    }
}

