using System;
using System.Collections.Generic;
using CreationalPattern.AbstractFactory.Factory;
using CreationalPattern.Builder;
using CreationalPattern.Product;

namespace CreationalPattern.Client
{
    //TODO corriger ma connerie en utilisant la partie builder
    //TODO voir si on factorise les clients
    public class BuilderClient : IClient
    {
        private HighSchoolBuilder _highSchoolBuilder { get; set; }
        private MiddleSchoolBuilder _middleSchoolBuilder { get; set; }
        private string _highSchool { get; set; }
        private string _middleSchool { get; set; }

        public BuilderClient()
        {
            _highSchoolBuilder = new HighSchoolBuilder();
            _middleSchoolBuilder = new MiddleSchoolBuilder();
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

            Etablishment etablishment = director.CreateHighSchool(builder, "Riverdale 's High School");

            DisplayInfoFromEtablishment(etablishment);
        }

        private void BuildMiddleSchool()
        {
            var builder = new MiddleSchoolBuilder();
            var director = new EtablishmentDirector();

            Etablishment etablishment = director.CreateMiddleSchool(builder, "Charles Xavier's Intitute");

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

