using System;
namespace CreationalPattern.Product.AbstractFactory
{
    public interface IStudent
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
        string Level
        {
            get;
            set;
        }
        string GetLevel();
    }
}

