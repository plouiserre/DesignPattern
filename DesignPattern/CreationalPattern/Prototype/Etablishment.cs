using System;
using System.Collections.Generic;
using CreationalPattern.Product;

namespace CreationalPattern.Prototype
{
    public abstract class Etablishment
    {
        public string Name { get; set; }

        public List<IStudent> Students { get; set; }

        public List<ITeacher> Teachers { get; set; }

        public Etablishment()
        {
            Students = new List<Product.IStudent>();
            Teachers = new List<Product.ITeacher>();
        }

        public Etablishment(Etablishment es)
        {
            Name = es.Name;
            Students = es.Students;
            Teachers = es.Teachers;
        }

        public abstract Etablishment Clone();
    }
}

