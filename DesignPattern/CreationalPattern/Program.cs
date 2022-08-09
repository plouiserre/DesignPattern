using System;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.AbstractFactory.Product;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting creation");
            var highSchoolFactory = new HighSchoolFactory();
            var middleSchoolFactory = new MiddleSchoolFactory();

            Console.WriteLine("Starting creation high school etablishement");
            HighSchoolPupil firstHighSchoolPupil = highSchoolFactory.CreatePupil("Archie", "Andrews", "11th grade", "Riverdale HighSchool") as HighSchoolPupil;
            HighSchoolPupil secondHighSchoolPupil = highSchoolFactory.CreatePupil("Betty", "Cooper", "11th grade", "Riverdale HighSchool") as HighSchoolPupil;
            HighSchoolTeacher firstHighSchoolTeacher = highSchoolFactory.CreateTeacher("James", "Howlett", "Sport", "Charles Xavier's Institut") as HighSchoolTeacher;
            HighSchoolTeacher secondHighSchoolTeacher = highSchoolFactory.CreateTeacher("Jean", "Grey", "Sciences", "Charles Xavier's Institut") as HighSchoolTeacher;
            Console.WriteLine("First pupil {0} {1} in {2} and in {3}", firstHighSchoolPupil.FirstName, firstHighSchoolPupil.LastName,
                firstHighSchoolPupil.Level, firstHighSchoolPupil.HighSchoolName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondHighSchoolPupil.FirstName, secondHighSchoolPupil.LastName,
                secondHighSchoolPupil.Level, secondHighSchoolPupil.HighSchoolName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstHighSchoolTeacher.FirstName, firstHighSchoolTeacher.LastName,
               firstHighSchoolTeacher.Discipline, firstHighSchoolTeacher.HighSchoolName);
            Console.WriteLine("Second pupil {0}{1} in {2} and in {3}", secondHighSchoolTeacher.FirstName, secondHighSchoolTeacher.LastName,
                secondHighSchoolTeacher.Discipline, secondHighSchoolTeacher.HighSchoolName);
            Console.WriteLine("Finish creation high school etablishement");

            Console.WriteLine("Starting creation middle school etablishement");
            MiddleSchoolPupil firstMiddleSchoolPupil = middleSchoolFactory.CreatePupil("Veronica", "Lodge", "11th grade", "Riverdale HighSchool") as MiddleSchoolPupil;
            MiddleSchoolPupil secondMiddleSchoolPupil = middleSchoolFactory.CreatePupil("Forsythe", "Pendleton", "11th grade", "Riverdale HighSchool") as MiddleSchoolPupil;
            MiddleSchoolTeacher firstMiddleSchoolTeacher = middleSchoolFactory.CreateTeacher("Ororo", "Munroe", "Maths", "Charles Xavier's Institut") as MiddleSchoolTeacher;
            MiddleSchoolTeacher secondMiddleSchoolTeacher = middleSchoolFactory.CreateTeacher("Scott", "Summers", "Literature", "Charles Xavier's Institut") as MiddleSchoolTeacher;
            Console.WriteLine("First pupil {0} {1} in {2} and in {3}", firstMiddleSchoolPupil.FirstName, firstMiddleSchoolPupil.LastName,
                firstMiddleSchoolPupil.Level, firstMiddleSchoolPupil.MiddleSchoolName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondMiddleSchoolPupil.FirstName, secondMiddleSchoolPupil.LastName,
                secondMiddleSchoolPupil.Level, secondMiddleSchoolPupil.MiddleSchoolName);
            Console.WriteLine("First teacher {0} {1} in {2} and in {3}", firstMiddleSchoolTeacher.FirstName, firstMiddleSchoolTeacher.LastName,
               firstMiddleSchoolTeacher.Discipline, firstMiddleSchoolTeacher.MiddleSchoolName);
            Console.WriteLine("Second pupil {0} {1} in {2} and in {3}", secondMiddleSchoolTeacher.FirstName, secondMiddleSchoolTeacher.LastName,
                secondMiddleSchoolTeacher.Discipline, secondMiddleSchoolTeacher.MiddleSchoolName);
            Console.WriteLine("Finish creation high school etablishement");

        }
    }
}
