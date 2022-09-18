using System;
using System.Collections.Generic;
using CreationalPattern.Product;

namespace CreationalPattern.Product
{
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

