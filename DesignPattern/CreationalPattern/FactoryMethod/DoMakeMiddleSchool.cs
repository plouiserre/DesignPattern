using System;
using CreationalPattern.Product;

namespace CreationalPattern.FactoryMethod
{
    public class DoMakeMiddleSchool : DoMakeEtablishment
    {
        public DoMakeMiddleSchool(string etablishmentName) :
            base(etablishmentName)
        {
        }

        public override Etablishment CreateEtablishment()
        {
            Etablishment middleSchool = MakeEtablishment();

            Teacher teacherFirst = MakeTeacher("Emma", "Frost", "politics");
            Teacher teacherSecond = MakeTeacher("Scott", "Summers", "Sport");

            Pupil pupilFirst = MakePupil("Sharon", "Smith", "11th");
            Pupil pupilSecond = MakePupil("Manuel", "De la rocha", "10th");
            Pupil pupilThird = MakePupil("Haroum", "ibn Sallah al-Rashid", "11th");
            Pupil pupilFourth = MakePupil("Mari-Ange", "Colbert", "11th");

            middleSchool.AddTeacher(teacherFirst);
            middleSchool.AddTeacher(teacherSecond);

            middleSchool.AddPupil(pupilFirst);
            middleSchool.AddPupil(pupilSecond);
            middleSchool.AddPupil(pupilThird);
            middleSchool.AddPupil(pupilFourth);

            return middleSchool;
        }

        public override Etablishment MakeEtablishment()
        {
            MiddleSchool middleSchool = new MiddleSchool(_etablishmentName);
            return middleSchool;
        }

        public override Pupil MakePupil(string firstName, string lastName, string level)
        {
            var pupil = new MiddleSchoolPupil(firstName, lastName, level, _etablishmentName);
            return pupil;
        }

        public override Teacher MakeTeacher(string firstName, string lastName, string discipline)
        {
            var teacher = new MiddleSchoolTeacher(firstName, lastName, discipline, _etablishmentName);
            return teacher;
        }
    }
}

