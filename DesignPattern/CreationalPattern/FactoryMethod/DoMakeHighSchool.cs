using System;
using CreationalPattern.Product;

namespace CreationalPattern.FactoryMethod
{
    public class DoMakeHighSchool : DoMakeEtablishment
    {
        public DoMakeHighSchool(string etablishmentName) : base(etablishmentName)
        {
        }

        public override Etablishment CreateEtablishment()
        {
            Etablishment highSchool = MakeEtablishment();

            Teacher teacherFirst = MakeTeacher("James", "Howlett", "sport");
            Teacher teacherSecond = MakeTeacher("Jean", "Grey", "mathematics");
            Teacher teacherThree = MakeTeacher("Katherine", "Pryde", "economics");

            Pupil pupilFirst = MakePupil("Douglas", "Ramsey", "11th");
            Pupil pupilSecond = MakePupil("Illyana", "Rasputin", "10th");
            Pupil pupilThird = MakePupil("Amara", "Aquilla", "11th");

            highSchool.AddTeacher(teacherFirst);
            highSchool.AddTeacher(teacherSecond);
            highSchool.AddTeacher(teacherThree);

            highSchool.AddPupil(pupilFirst);
            highSchool.AddPupil(pupilSecond);
            highSchool.AddPupil(pupilThird);

            return highSchool;
        }

        public override Etablishment MakeEtablishment()
        {
            HighSchool highSchool = new HighSchool(_etablishmentName);
            return highSchool;
        }

        public override Pupil MakePupil(string firstName, string lastName, string level)
        {
            HighSchoolPupil pupil = new HighSchoolPupil(firstName, lastName, level, _etablishmentName);
            return pupil;
        }

        public override Teacher MakeTeacher(string firstName, string lastName, string discipline)
        {
            HighSchoolTeacher teacher = new HighSchoolTeacher(firstName, lastName, discipline, _etablishmentName);
            return teacher;
        }
    }
}

