using System;
using CreationalPattern.Prototype;

namespace CreationalPattern.Client
{
    public class PrototypeClient : IClient
    {
        public HighSchool HighSchoolPrototype { get; set; }

        public MiddleSchool MiddleSchoolPrototype { get; set; }

        public PrototypeClient()
        {
        }

        public void CallPatern()
        {
            Console.WriteLine("Start Prototype");

            HighSchool highSchool = CreateHighSchool();
            HighSchool highSchoolCloned = highSchool.Clone() as HighSchool;

            MiddleSchool middleSchool = CreateMiddleSchool();
            MiddleSchool middleSchoolCloned = middleSchool.Clone() as MiddleSchool;

            Console.WriteLine("HighSchool Cloned {0} ", highSchoolCloned.Name);
            Console.WriteLine("{0} adults student in {1}", highSchoolCloned.AdultsStudentsNumber, highSchoolCloned.Name);
            foreach (var teacher in highSchoolCloned.Teachers)
            {
                Console.WriteLine("Teacher {0} {1} in {2}", teacher.FirstName, teacher.LastName, teacher.Discipline);
            }

            foreach (var student in highSchoolCloned.Students)
            {
                Console.WriteLine("Student {0} {1} in {2}", student.FirstName, student.LastName, student.Level);
            }

            Console.WriteLine("MiddleSchool Cloned {0} ", middleSchoolCloned.Name);

            if (middleSchoolCloned.SuburbMiddleSchool)
            {
                Console.WriteLine("{0} is in suburb", middleSchoolCloned.Name);
            }
            else
            {
                Console.WriteLine("{0} isn't in suburb", middleSchoolCloned.Name);
            }

            foreach (var teacher in middleSchoolCloned.Teachers)
            {
                Console.WriteLine("Teacher {0} {1} in {2}", teacher.FirstName, teacher.LastName, teacher.Discipline);
            }

            foreach (var student in middleSchoolCloned.Students)
            {
                Console.WriteLine("Student {0} {1} in {2}", student.FirstName, student.LastName, student.Level);
            }



            Console.WriteLine("End Prototype");
        }

        private HighSchool CreateHighSchool()
        {
            string highSchoolName = "Riverdale 's HighSchool";
            HighSchool highSchool = new HighSchool();
            highSchool.AdultsStudentsNumber = 56;
            highSchool.Name = highSchoolName;
            Product.HighSchoolStudent firstStudent = new Product.HighSchoolStudent("Veronica", "Lodge", highSchoolName, "11th grade");
            Product.HighSchoolStudent secondStudent = new Product.HighSchoolStudent("Betty", "Cooper", highSchoolName, "11th grade");
            Product.HighSchoolTeacher firstTeacher = new Product.HighSchoolTeacher("James", "Howlett", highSchoolName, "Sport");
            Product.HighSchoolTeacher secondTeacher = new Product.HighSchoolTeacher("Jean", "Grey", highSchoolName, "Sciences");

            highSchool.Students.Add(firstStudent);
            highSchool.Students.Add(secondStudent);
            highSchool.Teachers.Add(firstTeacher);
            highSchool.Teachers.Add(secondTeacher);

            return highSchool;
        }

        private MiddleSchool CreateMiddleSchool()
        {
            string middleSchoolName = "Charles Xavier's Institut";
            MiddleSchool middleSchool = new MiddleSchool();
            middleSchool.SuburbMiddleSchool = true;
            middleSchool.Name = middleSchoolName;

            Product.MiddleSchoolStudent firstStudent = new Product.MiddleSchoolStudent("Archie", "Andrews", "11th grade", middleSchoolName);
            Product.MiddleSchoolStudent secondStudent = new Product.MiddleSchoolStudent("Betty", "Cooper", "11th grade", middleSchoolName);
            Product.MiddleSchoolTeacher firstTeacher = new Product.MiddleSchoolTeacher("Ororo", "Munroe", "Maths", middleSchoolName);
            Product.MiddleSchoolTeacher secondTeacher = new Product.MiddleSchoolTeacher("Scott", "Summers", "Literature", middleSchoolName);

            middleSchool.Students.Add(firstStudent);
            middleSchool.Students.Add(secondStudent);
            middleSchool.Teachers.Add(firstTeacher);
            middleSchool.Teachers.Add(secondTeacher);

            return middleSchool;
        }
    }
}

