using InternshipTest.Person;
using System.Collections.Generic;
using System;

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

        public void AddListOfStudent(List<Student> students)
        {
            if (students != null)
            {
                foreach (var item in students)
                {
                    this.students.Add(new Student(item));
                }
            }
        }

        public void AddStudent(string line)//метод для майбутньої роботи з файлом чи базою даних
        {                                  //приклад стрічки: Andrew Kostenko 67
            string[] data = line.Split();
            Student student = new Student(data[0] + " " + data[1]);
            student.SetKnowledge(new Knowledge(System.Convert.ToUInt32(data[2])));
            students.Add(student);

        }
        public void AddStudent(Student student)     //я зрозумів, що ліпше додати студента за допомогою
        {                                           //копіювального конструктора, так як при багатьох атрибутах
            students.Add(new Student(student));     //додавання з допомогою них не буде ефективним 
        }

        public static double GetAverage(List<Student> students)
        {
            if (students.Count == 0)
            {
                try
                {
                    throw new Exception("List of students is empty");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            double average = 0;
            double sum = 0;

            foreach (var item in students)
            {
                sum += item.knowledge.level;
            }

            average = sum / (double)students.Count;

            return average;
        }

        public List<Student> GetListOfStudents()
        {           
            List<Student> intership_student = new List<Student>();
            double average = GetAverage(this.students); ;
        
            foreach (var item in students)
            {
                if (average < item.knowledge.level)
                {
                    intership_student.Add(new Student(item));
                }
            }

            return intership_student;

        }
    }
}
