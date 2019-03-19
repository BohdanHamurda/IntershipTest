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
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("Maria Perechrest"));

            university.students[0].SetKnowledge(new Knowledge(9));
            university.students[1].SetKnowledge(new Knowledge(7));
            university.students[2].SetKnowledge(new Knowledge(4));
            university.students[3].SetKnowledge(new Knowledge(8));
            university.students[4].SetKnowledge(new Knowledge(3));
            university.students[5].SetKnowledge(new Knowledge(6));
            university.students[6].SetKnowledge(new Knowledge(7));
            university.students[7].SetKnowledge(new Knowledge(4));


            Internship internship = new Internship("Interlink");
            internship.SetStudent(university.GetAverage());
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
