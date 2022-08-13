using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    //TODO add student and teachers in etablishment list
    public abstract class EtablishmentFactory
    {
        public abstract AbstractEtablishment CreateEtablishment(string name);

        public abstract AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, AbstractEtablishment etablishmentName);

        public abstract AbstractPupil CreatePupil(string firstName, string lastName, string level, AbstractEtablishment etablishmentName);
    }
}
