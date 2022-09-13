using System;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.Product;

namespace CreationalPattern.Client
{
    public class AbstractFactoryClient : IClient
    {
        private HighSchoolFactory _highSchoolFactory { get; set;  }
        private MiddleSchoolFactory _middleSchoolFactory { get; set; }
        private string _highSchool { get; set; }
        private string _middleSchool { get; set; }

        public AbstractFactoryClient()
        {
            _highSchool = "Riverdale HighSchool";
            _middleSchool = "Charles Xavier's Institut";
        }

        public void CallPatern()
        {
            Console.WriteLine("Starting creation");

            InitFactory();

            CreationHighSchool();

            CreationMiddleSchool();

            Console.WriteLine("End Creation");

            Console.Read();
        }

        private void InitFactory()
        {
            _highSchoolFactory = new HighSchoolFactory();
            _middleSchoolFactory = new MiddleSchoolFactory();
        }

        private void CreationHighSchool()
        {
            Console.WriteLine("Starting creation high school etablishement");
            var firstHighSchoolStudent = _highSchoolFactory.CreateStudent("Archie", "Andrews", "11th grade", _highSchool) as HighSchoolStudent;
            var secondHighSchoolStudent = _highSchoolFactory.CreateStudent("Betty", "Cooper", "11th grade", _highSchool) as HighSchoolStudent;
            var firstHighSchoolTeacher = _highSchoolFactory.CreateTeacher("James", "Howlett", "Sport", _highSchool) as HighSchoolTeacher;
            var secondHighSchoolTeacher = _highSchoolFactory.CreateTeacher("Jean", "Grey", "Sciences", _highSchool) as HighSchoolTeacher;
            Console.WriteLine("First Student {0} {1} in {2} and in {3}", firstHighSchoolStudent.FirstName, firstHighSchoolStudent.LastName,
                firstHighSchoolStudent.Level, firstHighSchoolStudent.EtablishmentName);
            Console.WriteLine("Second Student {0} {1} in {2} and in {3}", secondHighSchoolStudent.FirstName, secondHighSchoolStudent.LastName,
                secondHighSchoolStudent.Level, secondHighSchoolStudent.EtablishmentName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstHighSchoolTeacher.FirstName, firstHighSchoolTeacher.LastName,
               firstHighSchoolTeacher.Discipline, firstHighSchoolTeacher.EtablishmentName);
            Console.WriteLine("Second Student {0}{1} in {2} and in {3}", secondHighSchoolTeacher.FirstName, secondHighSchoolTeacher.LastName,
                secondHighSchoolTeacher.Discipline, secondHighSchoolTeacher.EtablishmentName);
            Console.WriteLine("Finish creation high school etablishement");
        }

        private void CreationMiddleSchool()
        {
            Console.WriteLine("Starting creation middle school etablishement");
            MiddleSchoolStudent firstMiddleSchoolStudent = _middleSchoolFactory.CreateStudent("Veronica", "Lodge", "11th grade", _middleSchool) as MiddleSchoolStudent;
            MiddleSchoolStudent secondMiddleSchoolStudent = _middleSchoolFactory.CreateStudent("Forsythe", "Pendleton", "11th grade", _middleSchool) as MiddleSchoolStudent;
            MiddleSchoolTeacher firstMiddleSchoolTeacher = _middleSchoolFactory.CreateTeacher("Ororo", "Munroe", "Maths", _middleSchool) as MiddleSchoolTeacher;
            MiddleSchoolTeacher secondMiddleSchoolTeacher = _middleSchoolFactory.CreateTeacher("Scott", "Summers", "Literature", _middleSchool) as MiddleSchoolTeacher;
            Console.WriteLine("First Student {0} {1} in {2} and in {3}", firstMiddleSchoolStudent.FirstName, firstMiddleSchoolStudent.LastName,
                firstMiddleSchoolStudent.Level, firstMiddleSchoolStudent.EtablishmentName);
            Console.WriteLine("Second Student {0} {1} in {2} and in {3}", secondMiddleSchoolStudent.FirstName, secondMiddleSchoolStudent.LastName,
                secondMiddleSchoolStudent.Level, secondMiddleSchoolStudent.EtablishmentName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstMiddleSchoolTeacher.FirstName, firstMiddleSchoolTeacher.LastName,
               firstMiddleSchoolTeacher.Discipline, firstMiddleSchoolTeacher.EtablishmentName);
            Console.WriteLine("Second Student {0} {1} in {2} and in {3}", secondMiddleSchoolTeacher.FirstName, secondMiddleSchoolTeacher.LastName,
                secondMiddleSchoolTeacher.Discipline, secondMiddleSchoolTeacher.EtablishmentName);
            Console.WriteLine("Finish creation high school etablishement");
        }
    }
}

