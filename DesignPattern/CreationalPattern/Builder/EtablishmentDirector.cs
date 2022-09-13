 using System;
using System.Collections.Generic;
using CreationalPattern.Product;
using CreationalPattern.Product.AbstractFactory;

namespace CreationalPattern.Builder
{
    public class EtablishmentDirector
    {
        public EtablishmentDirector()
        {
        }

        //TODO find a solution to the problem below
        //not perfect because I do not know how to pass argument for BuildPupil and BuildTeacher
        public Etablishment CreateEtablishment(EtablishmentBuilder builder, IList<IStudent> students, IList<ITeacher> teachers, string etablishmentName)
        {
            builder.BuildEtablishment(etablishmentName);
            foreach(ITeacher teacher in teachers)
            {
                builder.BuildTeacher(teacher);
            }
            foreach (IStudent student in students)
            {
                builder.BuildStudent(student);
            }
            return builder.GetEtablishment();
        }
    }
}

