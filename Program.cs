using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko"));
            university.AddStudent(new Student("Julia Veselkina"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("1Maria Perechrest"));
            university.AddStudent(new Student("2Maria Perechrest"));
            university.AddStudent(new Student("3Maria Perechrest"));
            university.AddStudent(new Student("4Maria Perechrest"));
            university.AddStudent(new Student("5Maria Perechrest"));

            s.SetKnowledge(new Knowledge(88));
            university.AddStudent(s);

            university.students[0].SetKnowledge(new Knowledge(90));
            university.students[1].SetKnowledge(new Knowledge(76));
            university.students[2].SetKnowledge(new Knowledge(48));
            university.students[3].SetKnowledge(new Knowledge(85));
            university.students[4].SetKnowledge(new Knowledge(38));
            university.students[5].SetKnowledge(new Knowledge(66));
            university.students[6].SetKnowledge(new Knowledge(78));
            university.students[7].SetKnowledge(new Knowledge(44));



            Internship internship = new Internship("Interlink");
            internship.SetStudent(university.GetListOfStudents());
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
