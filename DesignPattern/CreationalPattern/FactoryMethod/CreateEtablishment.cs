using System;
using CreationalPattern.Product.AbstractFactory;

namespace CreationalPattern.FactoryMethod
{
    public abstract class CreateEtablishment
    {
        protected string _etablishmentName { get; set; }

        public CreateEtablishment(string etablishmentName)
        {
            _etablishmentName = etablishmentName;
        }

        public abstract ITeacher MakeTeacher(string firstName, string lastName, string discipline);

        public abstract IStudent MakeStudent(string firstName, string lastName, string level);

    }
}

