using System;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public abstract class EtablishmentBuilder
    {
        public abstract void BuildEtablishment(string name);

        public abstract void BuildTeacher(string firstName, string lastName, string discipline);

        public abstract void BuildPupil(string firstName, string lastName, string level);

        public abstract AbstractEtablishment GetEtablishment();

        public EtablishmentBuilder()
        {
        }
    }
}

