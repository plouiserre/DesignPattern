using System;
using System.Collections.Generic;
using CreationalPattern.Product.AbstractFactory;

namespace CreationalPattern.Product
{
    //TODO rename AbstractEtablishment in Etablishment and check I can pass this class to an abstract class
    public class Etablishment
    {
        public string Name { get; set; }

        public List<ITeacher> Teachers { get; set; }

        public List<IStudent> Students { get; set; }


        public Etablishment(string name)
        {
            Name = name;
            Teachers = new List<ITeacher>();
            Students = new List<IStudent>();
        }


        public void AddTeacher(ITeacher teacher)
        {
            Teachers.Add(teacher);
        }


        public void AddStudent(IStudent student)
        {
            Students.Add(student);
        }
    }
}

