using System;
using System.Collections.Generic;

namespace CreationalPattern.Product
{
    //TODO rename AbstractEtablishment in Etablishment and check I can pass this class to an abstract class
    public class Etablishment
    {
        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Pupil> Pupils { get; set; }


        public Etablishment(string name)
        {
            Name = name;
            Teachers = new List<Teacher>();
            Pupils = new List<Pupil>();
        }


        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }


        public void AddPupil(Pupil pupil)
        {
            Pupils.Add(pupil);
        }
    }
}

