using System;
using CreationalPattern.Product;

namespace CreationalPattern.FactoryMethod
{
    //TODO improve CreaateEtablishment because I have the same issue than Builder Pattern
    public abstract class DoMakeEtablishment
    {
        protected string _etablishmentName { get; set; }

        private Etablishment _etablishment { get; set; }

        public DoMakeEtablishment(string etablishmentName)
        {
            _etablishmentName = etablishmentName;
        }

        public abstract Etablishment CreateEtablishment();

        public abstract Etablishment MakeEtablishment();

        public abstract Teacher MakeTeacher(string firstName, string lastName, string discipline);

        public abstract Pupil MakePupil(string firstName, string lastName, string level);

    }
}

