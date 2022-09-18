using System;
using CreationalPattern.Product;

namespace CreationalPattern.Builder
{
    public interface EtablishmentBuilder
    {
        public abstract void BuildEtablishment(string name);

        public abstract void BuildTeacher(string firstname, string lastname, string discipline);

        public abstract void BuildStudent(string firstname, string lastname, string level);

        public abstract Etablishment GetEtablishment();

    }
}

