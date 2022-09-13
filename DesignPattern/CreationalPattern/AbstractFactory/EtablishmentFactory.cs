 using System;
using CreationalPattern.Product;
using CreationalPattern.Product.AbstractFactory;

namespace CreationalPattern.AbstractFactory.Factory
{
    //TODO add student and teachers in etablishment list
    public interface EtablishmentFactory
    {
        public abstract ITeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName);

        public abstract IStudent CreateStudent(string firstName, string lastName, string level, string etablishmentName);
    }
}
