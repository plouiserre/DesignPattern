using System;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.Product;

namespace CreationalPattern.Client
{
    public class AbstractFactoryClient : IClient
    {
        private HighSchoolFactory _highSchoolFactory { get; set;  }
        private MiddleSchoolFactory _middleSchoolFactory { get; set; }
        private HighSchool _highSchool { get; set; }
        private MiddleSchool _middleSchool { get; set; }

        public AbstractFactoryClient()
        {
        }

        public void CallPatern()
        {
            Console.WriteLine("Starting creation");

            InitFactory();

            CreationEtablishment();

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

        private void CreationEtablishment()
        {
            Console.WriteLine("Starting creation  etablishment");
            _highSchool = _highSchoolFactory.CreateEtablishment("Riverdale HighSchool") as HighSchool;
            _middleSchool = _middleSchoolFactory.CreateEtablishment("Charles Xavier's Institut") as MiddleSchool;
            Console.WriteLine("Ending creation  etablishment");
        }

        private void CreationHighSchool()
        {
            Console.WriteLine("Starting creation high school etablishement");
            var firstHighSchoolPupil = _highSchoolFactory.CreatePupil("Archie", "Andrews", "11th grade", _highSchool) as HighSchoolPupil;
            var secondHighSchoolPupil = _highSchoolFactory.CreatePupil("Betty", "Cooper", "11th grade", _highSchool) as HighSchoolPupil;
            var firstHighSchoolTeacher = _highSchoolFactory.CreateTeacher("James", "Howlett", "Sport", _highSchool) as HighSchoolTeacher;
            var secondHighSchoolTeacher = _highSchoolFactory.CreateTeacher("Jean", "Grey", "Sciences", _highSchool) as HighSchoolTeacher;
            Console.WriteLine("First pupil {0} {1} in {2} and in {3}", firstHighSchoolPupil.FirstName, firstHighSchoolPupil.LastName,
                firstHighSchoolPupil.Level, firstHighSchoolPupil.EtablishmentName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondHighSchoolPupil.FirstName, secondHighSchoolPupil.LastName,
                secondHighSchoolPupil.Level, secondHighSchoolPupil.EtablishmentName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstHighSchoolTeacher.FirstName, firstHighSchoolTeacher.LastName,
               firstHighSchoolTeacher.Discipline, firstHighSchoolTeacher.EtablishmentName);
            Console.WriteLine("Second pupil {0}{1} in {2} and in {3}", secondHighSchoolTeacher.FirstName, secondHighSchoolTeacher.LastName,
                secondHighSchoolTeacher.Discipline, secondHighSchoolTeacher.EtablishmentName);
            Console.WriteLine("Finish creation high school etablishement");
        }

        private void CreationMiddleSchool()
        {
            Console.WriteLine("Starting creation middle school etablishement");
            MiddleSchoolPupil firstMiddleSchoolPupil = _middleSchoolFactory.CreatePupil("Veronica", "Lodge", "11th grade", _middleSchool) as MiddleSchoolPupil;
            MiddleSchoolPupil secondMiddleSchoolPupil = _middleSchoolFactory.CreatePupil("Forsythe", "Pendleton", "11th grade", _middleSchool) as MiddleSchoolPupil;
            MiddleSchoolTeacher firstMiddleSchoolTeacher = _middleSchoolFactory.CreateTeacher("Ororo", "Munroe", "Maths", _middleSchool) as MiddleSchoolTeacher;
            MiddleSchoolTeacher secondMiddleSchoolTeacher = _middleSchoolFactory.CreateTeacher("Scott", "Summers", "Literature", _middleSchool) as MiddleSchoolTeacher;
            Console.WriteLine("First pupil {0} {1} in {2} and in {3}", firstMiddleSchoolPupil.FirstName, firstMiddleSchoolPupil.LastName,
                firstMiddleSchoolPupil.Level, firstMiddleSchoolPupil.EtablishmentName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondMiddleSchoolPupil.FirstName, secondMiddleSchoolPupil.LastName,
                secondMiddleSchoolPupil.Level, secondMiddleSchoolPupil.EtablishmentName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstMiddleSchoolTeacher.FirstName, firstMiddleSchoolTeacher.LastName,
               firstMiddleSchoolTeacher.Discipline, firstMiddleSchoolTeacher.EtablishmentName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondMiddleSchoolTeacher.FirstName, secondMiddleSchoolTeacher.LastName,
                secondMiddleSchoolTeacher.Discipline, secondMiddleSchoolTeacher.EtablishmentName);
            Console.WriteLine("Finish creation high school etablishement");
        }
    }
}

