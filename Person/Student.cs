namespace InternshipTest.Person
{
    public class Student
    {
        public string name { get; }
        public Knowledge knowledge { get; private set; }
        public Student(string name)
        {
            this.name = name;
            knowledge = new Knowledge(0);
        }

        public Student(Student student)
        {
            name = student.name;
            knowledge = new Knowledge(student.knowledge.level);
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = new Knowledge(knowledge.level);          
        }
    }
}