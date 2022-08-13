using System;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public abstract class EtablishmentBuilder
    {
        public abstract void BuildEtablishment();

        public abstract void BuildTeacher(string firstName, string lastName, string discipline, string etablishmentName);

        public abstract void BuildPupil(string firstName, string lastName, string level, string etablishmentName);

        //public abstract 

        public EtablishmentBuilder()
        {
        }
    }
}

