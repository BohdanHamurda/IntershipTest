using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string name { get; private set; }
        public List<Student> students { get; private set; }

        public Internship(string name)
        {
            students = new List<Student>();
            this.name = name;   
        }

        public void SetStudent(List<Student> students) //Adds students to intership
        {
            for (int i = 0; i < students.Count; i++)
            {
                this.students.Add(new Student(students[i]));
            }
        }

        public string GetStudents()
        {
            string ListStudent = "";

            if (students.Count > 0)
            {
                foreach (var item in students)
                {
                    ListStudent += item.name + "\n";
                }
            }
            else
            {
                ListStudent = "No one";
            }
                
            return ListStudent;
        }
    }
}
