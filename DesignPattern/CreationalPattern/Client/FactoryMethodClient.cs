using System;
using System.Collections.Generic;
using CreationalPattern.FactoryMethod;
using CreationalPattern.Product;

namespace CreationalPattern.Client
{
    public class FactoryMethodClient : IClient
    {
        public FactoryMethodClient()
        {
        }

        public void CallPatern()
        {
            var factoryHighSchool = new CreateHighSchool("Xavier Institute");
            var factoryMiddleSchool = new CreateMiddleSchool("Massachusetts Academy");

            ITeacher teacherFirst = factoryHighSchool.MakeTeacher("James", "Howlett", "sport");
            ITeacher teacherSecond = factoryHighSchool.MakeTeacher("Katherine", "Pryde", "economics");

            IStudent studentFirst = factoryHighSchool.MakeStudent("Illyana", "Raspoutine", "12");
            IStudent studentSecond = factoryHighSchool.MakeStudent("Joshua", "Foley", "10");
            IStudent studentThird = factoryHighSchool.MakeStudent("Tabitha", "Smith", "11");


            ITeacher teacherThird = factoryMiddleSchool.MakeTeacher("Emma", "Frost", "mode");
            ITeacher teacherFourth = factoryMiddleSchool.MakeTeacher("Sebastian", "Shaw", "psychologics");
            ITeacher teacherFifth = factoryMiddleSchool.MakeTeacher("Harry", "Leleand", "politics");

            IStudent studentFourth = factoryMiddleSchool.MakeStudent("Julian", "Keller", "9");
            IStudent studentFifth = factoryMiddleSchool.MakeStudent("Sofía", "Mantega Barrett", "12");

            var teachers = new List<ITeacher>();
            teachers.Add(teacherFirst);
            teachers.Add(teacherSecond);
            teachers.Add(teacherThird);
            teachers.Add(teacherFourth);
            teachers.Add(teacherFifth);

            var students = new List<IStudent>();
            students.Add(studentFirst);
            students.Add(studentSecond);
            students.Add(studentThird);
            students.Add(studentFourth);
            students.Add(studentFifth);


            foreach(ITeacher teacher in teachers)
            {
                Console.WriteLine("Professor {0} {1} in {2}", teacher.FirstName, teacher.LastName, teacher.Discipline);
            }

            foreach (IStudent student in students)
            {
                Console.WriteLine("Student {0} {1} in {2}", student.FirstName, student.LastName, student.Level);
            }
            
        }
    }
}

