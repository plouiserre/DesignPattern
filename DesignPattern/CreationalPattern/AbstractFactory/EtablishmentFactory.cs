 using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    //TODO add student and teachers in etablishment list
    public abstract class EtablishmentFactory
    {
        public abstract Etablishment CreateEtablishment(string name);

        public abstract Teacher CreateTeacher(string firstName, string lastName, string discipline, Etablishment etablishmentName);

        public abstract Pupil CreatePupil(string firstName, string lastName, string level, Etablishment etablishmentName);
    }
}
