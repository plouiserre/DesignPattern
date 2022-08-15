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
            var factoryHighSchool = new DoMakeHighSchool("Xavier Institute");
            var factoryMiddleSchool = new DoMakeMiddleSchool("Massachusetts Academy");

            Etablishment firstEtablishment = factoryHighSchool.CreateEtablishment();
            Etablishment secondEtablishment = factoryMiddleSchool.CreateEtablishment();

            List<Etablishment> etablishments = new List<Etablishment>();
            etablishments.Add(firstEtablishment);
            etablishments.Add(secondEtablishment);

            Console.WriteLine("Start display of Factory Method");
            foreach (Etablishment etablishment in etablishments)
            {
                Console.WriteLine("Welcome in {0}", etablishment.Name);
                Console.WriteLine("In {0}, we are presenting you our teachers");
                foreach(Teacher teacher in etablishment.Teachers)
                {
                    Console.WriteLine("Professor {0} {1} in {2}", teacher.FirstName, teacher.LastName, teacher.Discipline);
                }
                Console.WriteLine("Now this is the turn for our student");
                foreach (Pupil pupil in etablishment.Pupils)
                {
                    Console.WriteLine("Professor {0} {1} in {2}", pupil.FirstName, pupil.LastName, pupil.Level);
                }
            }
            Console.WriteLine("End display of Factory Method");
        }
    }
}

