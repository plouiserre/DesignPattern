using System;
using System.Collections.Generic;
using CreationalPattern.Singleton;

namespace CreationalPattern.Client
{
    public class SingletonClient : IClient
    {
        private Etablishment _etablishment { get; set; }

        public SingletonClient()
        {
        }

        public void CallPatern()
        {
            Console.WriteLine("Singleton start");
            _etablishment = Etablishment.GetInstance();
            
            FirstEtablishment();

            _etablishment = Etablishment.GetInstance();

            SecondEtablishment();

            Console.WriteLine("Singleton end");
        }

        private void FirstEtablishment()
        {
            Console.WriteLine("first try");

            _etablishment.EtablishmentName = "Charles Xavier's Institut";
            List<Product.IStudent> students = new List<Product.IStudent>();
            List<Product.ITeacher> teachers = new List<Product.ITeacher>();
            var firstStudent = new Product.HighSchoolStudent("Veronica", "Lodge", _etablishment.EtablishmentName, "11th grade");
            var secondStudent = new Product.HighSchoolStudent("Betty", "Cooper", _etablishment.EtablishmentName, "11th grade");
            var firstTeacher = new Product.HighSchoolTeacher("James", "Howlett", _etablishment.EtablishmentName, "Sport");
            var secondTeacher = new Product.HighSchoolTeacher("Jean", "Grey", _etablishment.EtablishmentName, "Sciences");

            students.Add(firstStudent);
            students.Add(secondStudent);
            teachers.Add(firstTeacher);
            teachers.Add(secondTeacher);

            _etablishment.AddStudents(students);
            _etablishment.AddTeachers(teachers);

            CheckEtablishment();
        }

        private void SecondEtablishment()
        {
            Console.WriteLine("second try");
            List<Product.IStudent> students = new List<Product.IStudent>();
            List<Product.ITeacher> teachers = new List<Product.ITeacher>();

            var firstStudent = new Product.HighSchoolStudent("Archie", "Andrews", _etablishment.EtablishmentName, "11th grade");
            var secondStudent = new Product.HighSchoolStudent("Jughead", "Jones", _etablishment.EtablishmentName, "10th grade");
            var firstTeacher = new Product.HighSchoolTeacher("Ororo", "Munroe", _etablishment.EtablishmentName, "Maths");
            var secondTeacher = new Product.HighSchoolTeacher("Scott", "Summers", _etablishment.EtablishmentName, "Literature");

            students.Add(firstStudent);
            students.Add(secondStudent);
            teachers.Add(firstTeacher);
            teachers.Add(secondTeacher);

            _etablishment.AddStudents(students);
            _etablishment.AddTeachers(teachers);

            CheckEtablishment();
        }

        private void CheckEtablishment()
        {
            Console.WriteLine("Name School {0}", _etablishment.EtablishmentName);

            foreach (Product.IStudent student in _etablishment.Students)
            {
                Console.WriteLine("{0} {1} in {2} {3} level", student.FirstName, student.LastName,
                    student.EtablishmentName, student.Level);
            }

            foreach (Product.ITeacher teacher in _etablishment.Teachers)
            {
                Console.WriteLine("{0} {1} in {2} teaching {3}", teacher.FirstName, teacher.LastName,
                    teacher.EtablishmentName, teacher.Discipline);
            }
        }
    }
}

