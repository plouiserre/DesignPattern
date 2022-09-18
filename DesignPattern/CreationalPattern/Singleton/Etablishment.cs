using System;
using System.Collections.Generic;
using CreationalPattern.Product;

namespace CreationalPattern.Singleton
{
    public class Etablishment
    {
        private static Etablishment _instance { get; set; }


        public List<ITeacher> Teachers { get; set; }

        public List<IStudent> Students { get; set; }

        public string EtablishmentName { get; set; }

        private Etablishment()
        {
            Teachers = new List<ITeacher>();
            Students = new List<IStudent>();
        }

        public static Etablishment GetInstance()
        {
            if (_instance == null)
                _instance = new Etablishment();
            return _instance;
        }

        public void AddTeachers(List<ITeacher> teachers)
        {
            Teachers.AddRange(teachers);
        }

        public void AddStudents(List<IStudent> students)
        {
            Students.AddRange(students);
        }
    }
}

