using System;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.Product;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting creation");
            var highSchoolFactory = new HighSchoolFactory();
            var middleSchoolFactory = new MiddleSchoolFactory();

            Console.WriteLine("Starting creation  etablishment");
            var highSchool = highSchoolFactory.CreateEtablishment("Riverdale HighSchool") as HighSchool;
            var middleSchool = middleSchoolFactory.CreateEtablishment("Charles Xavier's Institut") as MiddleSchool;
            Console.WriteLine("Ending creation  etablishment");

            Console.WriteLine("Starting creation high school etablishement");
            var firstHighSchoolPupil = highSchoolFactory.CreatePupil("Archie", "Andrews", "11th grade", highSchool) as HighSchoolPupil;
            var secondHighSchoolPupil = highSchoolFactory.CreatePupil("Betty", "Cooper", "11th grade", highSchool) as HighSchoolPupil;
            var firstHighSchoolTeacher = highSchoolFactory.CreateTeacher("James", "Howlett", "Sport", highSchool) as HighSchoolTeacher;
            var secondHighSchoolTeacher = highSchoolFactory.CreateTeacher("Jean", "Grey", "Sciences", highSchool) as HighSchoolTeacher;
            Console.WriteLine("First pupil {0} {1} in {2} and in {3}", firstHighSchoolPupil.FirstName, firstHighSchoolPupil.LastName,
                firstHighSchoolPupil.Level, firstHighSchoolPupil.EtablishmentName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondHighSchoolPupil.FirstName, secondHighSchoolPupil.LastName,
                secondHighSchoolPupil.Level, secondHighSchoolPupil.EtablishmentName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstHighSchoolTeacher.FirstName, firstHighSchoolTeacher.LastName,
               firstHighSchoolTeacher.Discipline, firstHighSchoolTeacher.EtablishmentName);
            Console.WriteLine("Second pupil {0}{1} in {2} and in {3}", secondHighSchoolTeacher.FirstName, secondHighSchoolTeacher.LastName,
                secondHighSchoolTeacher.Discipline, secondHighSchoolTeacher.EtablishmentName);
            Console.WriteLine("Finish creation high school etablishement");

            Console.WriteLine("Starting creation middle school etablishement");
            MiddleSchoolPupil firstMiddleSchoolPupil = middleSchoolFactory.CreatePupil("Veronica", "Lodge", "11th grade", middleSchool) as MiddleSchoolPupil;
            MiddleSchoolPupil secondMiddleSchoolPupil = middleSchoolFactory.CreatePupil("Forsythe", "Pendleton", "11th grade", middleSchool) as MiddleSchoolPupil;
            MiddleSchoolTeacher firstMiddleSchoolTeacher = middleSchoolFactory.CreateTeacher("Ororo", "Munroe", "Maths", middleSchool) as MiddleSchoolTeacher;
            MiddleSchoolTeacher secondMiddleSchoolTeacher = middleSchoolFactory.CreateTeacher("Scott", "Summers", "Literature", middleSchool) as MiddleSchoolTeacher;
            Console.WriteLine("First pupil {0} {1} in {2} and in {3}", firstMiddleSchoolPupil.FirstName, firstMiddleSchoolPupil.LastName,
                firstMiddleSchoolPupil.Level, firstMiddleSchoolPupil.EtablishmentName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondMiddleSchoolPupil.FirstName, secondMiddleSchoolPupil.LastName,
                secondMiddleSchoolPupil.Level, secondMiddleSchoolPupil.EtablishmentName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstMiddleSchoolTeacher.FirstName, firstMiddleSchoolTeacher.LastName,
               firstMiddleSchoolTeacher.Discipline, firstMiddleSchoolTeacher.EtablishmentName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondMiddleSchoolTeacher.FirstName, secondMiddleSchoolTeacher.LastName,
                secondMiddleSchoolTeacher.Discipline, secondMiddleSchoolTeacher.EtablishmentName);
            Console.WriteLine("Finish creation high school etablishement");

            Console.Read();

        }
    }
}
