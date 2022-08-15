using System;
using System.Collections.Generic;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public class EtablishmentDirector
    {
        public EtablishmentDirector()
        {
        }

        //TODO find a solution to the problem below
        //not perfect because I do not know how to pass argument for BuildPupil and BuildTeacher
        public Etablishment CreateEtablishment(EtablishmentBuilder builder, string etablishmentName)
        {
            builder.BuildEtablishment(etablishmentName);
            builder.BuildPupil("Sam", "Guthrie", "11th");
            builder.BuildTeacher("Katherine", "Pryde", "History"); 
            return builder.GetEtablishment();
        }
    }
}

