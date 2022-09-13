using System;
using System.Collections.Generic;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.Builder;
using CreationalPattern.Product;
using CreationalPattern.Product.AbstractFactory;

namespace CreationalPattern.Client
{
    //TODO  finish this client when the problem present in EtablishmentDirector will be solved
    //TODO factoriser les clients
    public class BuilderClient : IClient
    {
        private HighSchoolFactory _highSchoolFactory { get; set; }
        private MiddleSchoolFactory _middleSchoolFactory { get; set; }
        private string _highSchool { get; set; }
        private string _middleSchool { get; set; }

        public BuilderClient()
        {
            _highSchoolFactory = new HighSchoolFactory();
            _middleSchoolFactory = new MiddleSchoolFactory();
            _highSchool = "Riverdale HighSchool";
            _middleSchool = "Charles Xavier's Institut";
        }

        public void CallPatern()
        {
            BuildHighSchool();
            BuildMiddleSchool();
        }

        private void BuildHighSchool()
        {
            var builder = new HighSchoolBuilder();
            var director = new EtablishmentDirector();

            var firstHighSchoolStudent = _highSchoolFactory.CreateStudent("Archie", "Andrews", "11th grade", _highSchool) as Product.AbstractFactory.HighSchoolStudent;
            var secondHighSchoolStudent = _highSchoolFactory.CreateStudent("Betty", "Cooper", "11th grade", _highSchool) as Product.AbstractFactory.HighSchoolStudent;
            var students = new List<IStudent>();
            students.Add(firstHighSchoolStudent);
            students.Add(secondHighSchoolStudent);

            var firstHighSchoolTeacher = _highSchoolFactory.CreateTeacher("James", "Howlett", "Sport", _highSchool) as Product.AbstractFactory.HighSchoolTeacher;
            var secondHighSchoolTeacher = _highSchoolFactory.CreateTeacher("Jean", "Grey", "Sciences", _highSchool) as Product.AbstractFactory.HighSchoolTeacher;
            var teachers = new List<Product.AbstractFactory.ITeacher>();
            teachers.Add(firstHighSchoolTeacher);
            teachers.Add(secondHighSchoolTeacher);

            Etablishment etablishment = director.CreateEtablishment(builder, students, teachers, "Riverdale 's High School");

            DisplayInfoFromEtablishment(etablishment);
        }

        private void BuildMiddleSchool()
        {
            var builder = new MiddleSchoolBuilder();
            var director = new EtablishmentDirector();
            var firstMiddleSchoolStudent = _middleSchoolFactory.CreateStudent("Veronica", "Lodge", "11th grade", _middleSchool) as MiddleSchoolStudent;
            var secondMiddleSchoolStudent = _middleSchoolFactory.CreateStudent("Forsythe", "Pendleton", "11th grade", _middleSchool) as MiddleSchoolStudent;
            var students = new List<IStudent>();
            students.Add(firstMiddleSchoolStudent);
            students.Add(secondMiddleSchoolStudent);

            var firstMiddleSchoolTeacher = _middleSchoolFactory.CreateTeacher("Ororo", "Munroe", "Maths", _middleSchool) as Product.AbstractFactory.MiddleSchoolTeacher;
            var secondMiddleSchoolTeacher = _middleSchoolFactory.CreateTeacher("Scott", "Summers", "Literature", _middleSchool) as Product.AbstractFactory.MiddleSchoolTeacher;
            var teachers = new List<ITeacher>();
            teachers.Add(firstMiddleSchoolTeacher);
            teachers.Add(secondMiddleSchoolTeacher);


            Etablishment etablishment = director.CreateEtablishment(builder, students, teachers, "Charles Xavier's Intitute");

            DisplayInfoFromEtablishment(etablishment);
        }

        private void DisplayInfoFromEtablishment(Etablishment etablishment)
        {
            Console.WriteLine("{0} is an high school with {1} teacher(s) and {2} pupil(s)",
                etablishment.Name, etablishment.Teachers.Count, etablishment.Students.Count);

            foreach (ITeacher teacher in etablishment.Teachers)
            {
                Console.WriteLine("{0} {1} is teaching {2} in {3}", teacher.FirstName, teacher.LastName,
                    teacher.Discipline, teacher.EtablishmentName);
            }

            foreach (IStudent student in etablishment.Students)
            {
                Console.WriteLine("{0} {1} is in {2} in {3}", student.FirstName, student.LastName, student.Level, student.EtablishmentName);
            }
        }
    }
}

