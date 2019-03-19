using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        public string name { get; private set; }
        public List<Student> students { get; set; }
        public University(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(new Student(student.name));
        }

        public List<Student> GetAverage()
        {
            double Ave;
            double sum = 0;
            List<Student> InterShipStud = new List<Student>();

            foreach (var item in students)
            {
                sum +=item.knowledge.level;
            }

            Ave = sum / (double)students.Count;

            foreach (var item in students)
            {
                if (Ave < item.knowledge.level)
                {
                    InterShipStud.Add(new Student(item));
                }
            }

            return InterShipStud;

        }
    }
}
