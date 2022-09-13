 using System;
using CreationalPattern.Product;

namespace CreationalPattern.AbstractFactory.Factory
{
    public interface EtablishmentFactory
    {
        public abstract ITeacher CreateTeacher(string firstName, string lastName, string discipline, string etablishmentName);

        public abstract IStudent CreateStudent(string firstName, string lastName, string level, string etablishmentName);
    }
}
