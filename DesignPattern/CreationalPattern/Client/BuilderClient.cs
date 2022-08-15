using System;
using CreationalPattern.Builder;
using CreationalPattern.Product;

namespace CreationalPattern.Client
{
    //TODO  finish this client when the problem present in EtablishmentDirector will be solved
    public class BuilderClient : IClient
    {
        public BuilderClient()
        {
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
            Etablishment etablishment = director.CreateEtablishment(builder, "Riverdale 's High School");

            DisplayInfoFromEtablishment(etablishment);
        }

        private void BuildMiddleSchool()
        {
            var builder = new MiddleSchoolBuilder();
            var director = new EtablishmentDirector();
            Etablishment etablishment = director.CreateEtablishment(builder, "Charles Xavier's Intitute");

            DisplayInfoFromEtablishment(etablishment);
        }

        private void DisplayInfoFromEtablishment(Etablishment etablishment)
        {
            Console.WriteLine("{0} is an high school with {1} teacher(s) and {2} pupil(s)",
                etablishment.Name, etablishment.Teachers.Count, etablishment.Pupils.Count);

            foreach (Teacher teacher in etablishment.Teachers)
            {
                Console.WriteLine("{0} {1} is teaching {2} in {3}", teacher.FirstName, teacher.LastName,
                    teacher.Discipline, teacher.EtablishmentName);
            }

            foreach (Pupil pupil in etablishment.Pupils)
            {
                Console.WriteLine("{0} {1} is in {2} in {3}", pupil.FirstName, pupil.LastName, pupil.Level, pupil.EtablishmentName);
            }
        }
    }
}

