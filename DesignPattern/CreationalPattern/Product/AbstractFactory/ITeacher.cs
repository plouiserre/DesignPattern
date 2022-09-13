using System;
namespace CreationalPattern.Product.AbstractFactory
{
    public interface ITeacher
    {
        string FirstName
        {
            get;
            set;
        }
        string LastName
        {
            get;
            set;
        }
        string EtablishmentName
        {
            get;
            set;
        }
        string Discipline
        {
            get;
            set;
        }
        string GetDiscipline();
    }
}

