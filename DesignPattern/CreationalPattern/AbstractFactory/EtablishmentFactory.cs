using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public abstract class EtablishmentFactory
    {
        public abstract AbstractEtablishment CreateEtablishment(string name);

        public abstract AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, AbstractEtablishment etablishmentName);

        public abstract AbstractPupil CreatePupil(string firstName, string lastName, string level, AbstractEtablishment etablishmentName);
    }
}
