using System;
using System.Collections.Generic;

namespace CreationalPattern.Product
{
    public class AbstractEtablishment
    {
        public string Name { get; set; }

        public List<AbstractTeacher> Teachers { get; set; }

        public List<AbstractPupil> Pupils { get; set; }


        public AbstractEtablishment(string name)
        {
            Name = name;
            Teachers = new List<AbstractTeacher>();
            Pupils = new List<AbstractPupil>();
        }


        public void AddTeacher(AbstractTeacher teacher)
        {
            Teachers.Add(teacher);
        }


        public void AddPupil(AbstractPupil pupil)
        {
            Pupils.Add(pupil);
        }
    }
}

