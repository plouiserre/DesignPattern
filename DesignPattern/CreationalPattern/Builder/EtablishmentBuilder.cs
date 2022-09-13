using System;
using CreationalPattern.Product;
using CreationalPattern.Product.AbstractFactory;

namespace CreationalPattern.Builder
{
    public interface EtablishmentBuilder
    {
        public abstract void BuildEtablishment(string name);

        public abstract void BuildTeacher(ITeacher teacher);

        public abstract void BuildStudent(IStudent pupil);

        //TODO voir si on la supprime
        public abstract Etablishment GetEtablishment();

    }
}

