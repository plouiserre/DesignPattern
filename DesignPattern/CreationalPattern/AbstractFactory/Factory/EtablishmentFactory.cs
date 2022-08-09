using System;
using CreationalPattern.AbstractFactory.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public abstract class EtablishmentFactory
    {
        public abstract AbstractTeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName);

        public abstract AbstractPupil CreatePupil(string firstName, string lastName, string level, string etablishmentName);
    }
}
